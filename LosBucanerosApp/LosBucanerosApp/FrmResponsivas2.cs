using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LosBucanerosApp
{
    public partial class FrmResponsivas2 : Form
    {
        ClsRutas objrutas = new ClsRutas();
        string Nombre, Apellido, Permiso,Tipoempleado;
        private SqlConnection conn;
        private SqlCommand comm;
        public DataTable dt;
        public SqlDataAdapter adp;
        public FrmResponsivas2(string nombre, string apellido, string permiso, string tipoempleado)
        {
            InitializeComponent();
            Nombre = nombre;
            Apellido = apellido;
            Permiso = permiso;
            Tipoempleado = tipoempleado;
        }
        ClsResponsivas objresponsiva = new ClsResponsivas();
        private void FrmResponsivas2_Load(object sender, EventArgs e)
        {
            cmbestatus.SelectedIndex = -1;
            if (Tipoempleado == "Operador")
            {
                rbOperador.Checked = true;
                rbAdministrativo.Checked = false;
            }
            else if (Tipoempleado == "Administrativo")
            {
                rbOperador.Checked = false;
                rbAdministrativo.Checked = true;
            }
            CargarGridResponsivasActivas();
        }


        public void CargarGridResponsivasActivas()
        {
            //cuando esta disponible
            dgvResponsivas.DataSource = null;
            objresponsiva.populateGridResponsivasActivas(Tipoempleado);
            dgvResponsivas.DataSource = objresponsiva.dt;

            dgvResponsivas.ClearSelection();
           // dgvReponsivas.Columns.Add(DataGridViewImageCell dat);


        }

        private void dgvReponsivas_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                DataGridViewButtonCell cell = (DataGridViewButtonCell)dgvResponsivas.Rows[e.RowIndex].Cells[e.ColumnIndex];

                if (cell.Value.ToString() == "Ver Detalles")
                {
                    int selectedrowindex = dgvResponsivas.SelectedCells[0].RowIndex;
                    DataGridViewRow selectedRow = dgvResponsivas.Rows[selectedrowindex];
                    int ids = Convert.ToInt32(selectedRow.Cells["Id"].Value);

                    FrmDetallesResponsiva objdetalles = new FrmDetallesResponsiva(ids, Nombre, Apellido, Permiso,Tipoempleado);
                    objdetalles.Show();
                }

                if (cell.Value.ToString() == "Agregar")
                {
                    int selectedrowindex = dgvResponsivas.SelectedCells[0].RowIndex;
                    DataGridViewRow selectedRow = dgvResponsivas.Rows[selectedrowindex];
                    int ids = Convert.ToInt32(selectedRow.Cells["Id"].Value);


                    FrmAmazonPhoto photo = new FrmAmazonPhoto(ids.ToString(),Tipoempleado);
                    photo.Show();
                }
            }
            catch (Exception)
            {
                
                
            }
            
        }

        private void rbOperador_CheckedChanged(object sender, EventArgs e)
        {
            if (rbOperador.Checked == true)
            {
                Tipoempleado = "Operador";
            }
            CargarGridResponsivasActivas();
        }

        private void rbAdministrativo_CheckedChanged(object sender, EventArgs e)
        {
            if (rbAdministrativo.Checked == true)
            {
                Tipoempleado = "Administrativo";
            }
            CargarGridResponsivasActivas();
        }

        private void dgvResponsivas_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            lblcont.Font = new Font("Times New Roman", 15.75f, FontStyle.Bold);
            lblcont.Text = "Responsivas: " + dgvResponsivas.RowCount;
        }

        private void dgvResponsivas_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                if (dgvResponsivas.SelectedCells.Count > 0)
                {
                    int selectedrowindex = dgvResponsivas.SelectedCells[0].RowIndex;

                    DataGridViewRow selectedRow = dgvResponsivas.Rows[selectedrowindex];
                    id = Convert.ToString(selectedRow.Cells["Id"].Value);
                    tiporesponsiva = Convert.ToString(selectedRow.Cells["Tiporesponsiva"].Value);
                    btnEliminar.Enabled = true;
                }
                else
                {
                    btnEliminar.Enabled = false;
                }
            }
            catch (Exception)
            {


            }
        }

        private void txtbusqueda_TextChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex == -1)
            {
                MessageBox.Show("Seleccionar un criterio de busqueda valido");
                txtbusqueda.Text = "";
            }
            else if (comboBox1.SelectedIndex == 0)
            {
                (dgvResponsivas.DataSource as DataTable).DefaultView.RowFilter = string.Format("Id LIKE '%{0}%'", txtbusqueda.Text);
            }
            else if (comboBox1.SelectedIndex == 1)
            {
                (dgvResponsivas.DataSource as DataTable).DefaultView.RowFilter = string.Format("TELEFONO LIKE '%{0}%'", txtbusqueda.Text);
            }
            else if (comboBox1.SelectedIndex == 2)
            {
                (dgvResponsivas.DataSource as DataTable).DefaultView.RowFilter = string.Format("NOMBRE+APELLIDO '%{0}%'", txtbusqueda.Text);
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult X = MessageBox.Show("¿Seguro que desea cancelar esta responsiva?", "Cancelación", MessageBoxButtons.OKCancel);
                if (X == DialogResult.OK)
                {
                    X = MessageBox.Show("¿La cancelación es con devolución?", "Cancelación", MessageBoxButtons.YesNoCancel);
                    if (X == DialogResult.Yes)
                    {
                        X = MessageBox.Show("¿El empleado sera dado de baja?", "Baja Responsiva", MessageBoxButtons.YesNoCancel);
                        if (X == DialogResult.Yes)
                        {
                            aux = 1; CancelarResponsiva();
                        }
                        else if (X == DialogResult.No)
                        {
                            aux = 2; CancelarResponsiva();
                        }
                    }
                    else if (X == DialogResult.No)
                    {
                        try
                        {
                            //establecer parametros de conexion
                            conn = new SqlConnection(objrutas.connstring);
                            //abrir conexion con parametros previamente asignados
                            conn.Open();
                            //asignar comando de sql
                            comm = new SqlCommand("spDetallesResponsiva", conn);
                            //asignar conexion al comando
                            comm.Connection = conn;
                            //
                            comm.CommandType = CommandType.StoredProcedure;
                            comm.Parameters.AddWithValue("@id", id);
                            comm.Parameters.AddWithValue("@tipoempleado", Tipoempleado);
                            adp = new SqlDataAdapter(comm);
                            dt = new DataTable();
                            adp.Fill(dt);

                            DataRow row = dt.Rows[0];
                            id = row[0].ToString();
                            string operador = row[15].ToString() + " " + row[23].ToString() + " " + row[16].ToString() + " " + row[24].ToString();
                            conn.Close();
                            FrmDescuento Descuento = new FrmDescuento(id,operador,tiporesponsiva);
                            Descuento.ShowDialog();
                            //establecer parametros de conexion
                            conn = new SqlConnection(objrutas.connstring);
                            //abrir conexion con parametros previamente asignados
                            conn.Open();
                            //asignar comando de sql
                            comm = new SqlCommand("spInsertDescuento", conn);
                            //asignar conexion al comando
                            comm.Connection = conn;
                            //
                            comm.CommandType = CommandType.StoredProcedure;
                            
                            adp = new SqlDataAdapter(comm);
                            dt = new DataTable();
                            adp.Fill(dt);
                            conn.Close();
                            row = dt.Rows[0];
                            id = row[0].ToString();
                            string idresponsiva = row[1].ToString();
                            string tipodescuento = row[2].ToString();
                            string totaldescuento = row[3].ToString();
                            string fecha = row[4].ToString();
                            string comentarios = row[5].ToString();
                            
                        }
                        catch (Exception)
                        {

                            throw;
                        }
                        X = MessageBox.Show("¿El empleado sera dado de baja?", "Baja Responsiva", MessageBoxButtons.YesNoCancel);
                        if (X == DialogResult.Yes)
                        {
                            aux = 3; CancelarResponsiva(); objrutas.CorreoCancelacion();
                        }
                        else if (X == DialogResult.No)
                        {
                            aux = 4; CancelarResponsiva(); objrutas.CorreoCancelacion();
                        }
                    }
                }
            }
            catch (Exception)
            {

                throw;
            }
            aux = 0;
        }

        private void cmbestatus_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbestatus.SelectedIndex == 0)
            {
                (dgvResponsivas.DataSource as DataTable).DefaultView.RowFilter = "Estatus LIKE 'ACTIVO'";
            }
            else if (cmbestatus.SelectedIndex == 1)
            {
                (dgvResponsivas.DataSource as DataTable).DefaultView.RowFilter = "Estatus LIKE 'INACTIVO'";
            }
        }

        string id = "",tiporesponsiva = "";
        int aux = 0;
        private int resultado;

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        public void CancelarResponsiva()
        {
            try
            {
                //establecer parametros de conexion
                conn = new SqlConnection(objrutas.connstring);
                //abrir conexion con parametros previamente asignados
                conn.Open();
                //asignar comando de sql
                comm = new SqlCommand();
                //asignar conexion al comando
                comm.Connection = conn;
                //comando de tipo procedimiento almacenado
                comm.CommandType = CommandType.StoredProcedure;
                //nombre del procedimiento almacenado
                comm.CommandText = "spDeleteResponsiva";
                //enviamos los parametros del procedimiento almacenado
                comm.Parameters.AddWithValue("@id", Convert.ToInt32(id));
                comm.Parameters.AddWithValue("@aux", aux);

                comm.ExecuteNonQuery();
                resultado = 1;
                conn.Close();

            }
            catch (Exception ex)
            {
                resultado = 0;
                throw;
            }
        }

        private string toText(double value)
        {


            string Num2Text = "";


            value = Math.Truncate(value);


            if (value == 0) Num2Text = "CERO";


            else if (value == 1) Num2Text = "UNO";


            else if (value == 2) Num2Text = "DOS";


            else if (value == 3) Num2Text = "TRES";


            else if (value == 4) Num2Text = "CUATRO";


            else if (value == 5) Num2Text = "CINCO";


            else if (value == 6) Num2Text = "SEIS";


            else if (value == 7) Num2Text = "SIETE";


            else if (value == 8) Num2Text = "OCHO";


            else if (value == 9) Num2Text = "NUEVE";


            else if (value == 10) Num2Text = "DIEZ";


            else if (value == 11) Num2Text = "ONCE";


            else if (value == 12) Num2Text = "DOCE";


            else if (value == 13) Num2Text = "TRECE";


            else if (value == 14) Num2Text = "CATORCE";


            else if (value == 15) Num2Text = "QUINCE";


            else if (value < 20) Num2Text = "DIECI" + toText(value - 10);


            else if (value == 20) Num2Text = "VEINTE";


            else if (value < 30) Num2Text = "VEINTI" + toText(value - 20);


            else if (value == 30) Num2Text = "TREINTA";


            else if (value == 40) Num2Text = "CUARENTA";


            else if (value == 50) Num2Text = "CINCUENTA";


            else if (value == 60) Num2Text = "SESENTA";


            else if (value == 70) Num2Text = "SETENTA";


            else if (value == 80) Num2Text = "OCHENTA";


            else if (value == 90) Num2Text = "NOVENTA";


            else if (value < 100) Num2Text = toText(Math.Truncate(value / 10) * 10) + " Y " + toText(value % 10);


            else if (value == 100) Num2Text = "CIEN";


            else if (value < 200) Num2Text = "CIENTO " + toText(value - 100);


            else if ((value == 200) || (value == 300) || (value == 400) || (value == 600) || (value == 800)) Num2Text = toText(Math.Truncate(value / 100)) + "CIENTOS";


            else if (value == 500) Num2Text = "QUINIENTOS";


            else if (value == 700) Num2Text = "SETECIENTOS";


            else if (value == 900) Num2Text = "NOVECIENTOS";


            else if (value < 1000) Num2Text = toText(Math.Truncate(value / 100) * 100) + " " + toText(value % 100);


            else if (value == 1000) Num2Text = "MIL";


            else if (value < 2000) Num2Text = "MIL " + toText(value % 1000);


            else if (value < 1000000)
            {


                Num2Text = toText(Math.Truncate(value / 1000)) + " MIL";


                if ((value % 1000) > 0) Num2Text = Num2Text + " " + toText(value % 1000);


            }


            else if (value == 1000000) Num2Text = "UN MILLON";


            else if (value < 2000000) Num2Text = "UN MILLON " + toText(value % 1000000);


            else if (value < 1000000000000)
            {


                Num2Text = toText(Math.Truncate(value / 1000000)) + " MILLONES ";


                if ((value - Math.Truncate(value / 1000000) * 1000000) > 0) Num2Text = Num2Text + " " + toText(value - Math.Truncate(value / 1000000) * 1000000);


            }


            else if (value == 1000000000000) Num2Text = "UN BILLON";


            else if (value < 2000000000000) Num2Text = "UN BILLON " + toText(value - Math.Truncate(value / 1000000000000) * 1000000000000);


            else
            {


                Num2Text = toText(Math.Truncate(value / 1000000000000)) + " BILLONES";


                if ((value - Math.Truncate(value / 1000000000000) * 1000000000000) > 0) Num2Text = Num2Text + " " + toText(value - Math.Truncate(value / 1000000000000) * 1000000000000);


            }


            return Num2Text;


        }
        public string enletras(string num)
        {


            string res, dec = "";


            Int64 entero;


            int decimales;


            double nro;


            try
            {


                nro = Convert.ToDouble(num);


            }


            catch
            {


                return "";


            }


            entero = Convert.ToInt64(Math.Truncate(nro));


            decimales = Convert.ToInt32(Math.Round((nro - entero) * 100, 2));


            if (decimales > 0)
            {


                dec = " CON " + decimales.ToString() + "/ 100";


            }


            res = toText(Convert.ToDouble(entero)) + dec;


            return res;


        }
    }
}
