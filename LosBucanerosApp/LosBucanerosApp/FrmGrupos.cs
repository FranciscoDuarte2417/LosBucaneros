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
    public partial class FrmGrupos : Form
    {
        string Nombre, Apellido, Permiso;
        public FrmGrupos(string nombre, string apellido, string permiso)
        {
            InitializeComponent();
            Nombre = nombre;
            Apellido = apellido;
            Permiso = permiso;
        }
        public int resultado;
        ClsRutas objrutas = new ClsRutas();
        private SqlConnection conn;
        private SqlCommand comm;
        public DataTable dt;
        public DataTable dtgrupo;
        public DataTable dttractos;
        public SqlDataAdapter adp;
        int idtracto=0;

        private void cmbgrupos_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void FrmGrupos_Load(object sender, EventArgs e)
        {
            llenarComboGrupos();
        }

        private void btnregistrar_Click(object sender, EventArgs e)
        {
            
        }

        public void llenarComboGrupos()
        {
            conn = new SqlConnection(objrutas.connstring);
            //abrir conexion con parametros previamente asignados
            conn.Open();
            //asignar comando de sql
            comm = new SqlCommand("spPopulateGrupos", conn);
            //asignar conexion al comando
            comm.Connection = conn;
            //
            comm.CommandType = CommandType.StoredProcedure;

            //
            adp = new SqlDataAdapter(comm);
            dt = new DataTable();
            adp.Fill(dt);
            conn.Close();

            cmbgrupos.DataSource = null;
            cmbgrupos.DataSource = dt;
            cmbgrupos.ValueMember = "IdGrupo";
            cmbgrupos.DisplayMember = "NombreGrupo";
            cmbgrupos.SelectedIndex = -1;
        }
        
        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (lstTractos.SelectedIndex != -1)
            {
                DataRow Row = dttractos.Rows[Convert.ToInt32(lstTractos.SelectedIndex)];
                idtracto = Convert.ToInt32(Row[0].ToString());
                agregartracto();
                llenarListGrupo();
                llenarListTractos();
            }
        }

        public void agregartracto()
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
                comm.CommandText = "spInsertAsignacionGrupo";
                //enviamos los parametros del procedimiento almacenado
                comm.Parameters.AddWithValue("@idtracto", idtracto);
                comm.Parameters.AddWithValue("@idgrupo", Convert.ToInt32(cmbgrupos.SelectedValue.ToString()));

                comm.ExecuteNonQuery();
                resultado = 1;
                conn.Close();
                
            }
            catch (Exception ex)
            {
                if (ex.Message == "Hubo un problema al insertar")
                {
                    resultado = 2;
                }
                else
                {
                    resultado = 0;
                }

                //throw;
            }
        }

        private void btneliminar_Click(object sender, EventArgs e)
        {
            if (lstBitacora.SelectedIndex != -1)
            {
                DataRow Row = dtgrupo.Rows[Convert.ToInt32(lstBitacora.SelectedIndex)];
                idtracto = Convert.ToInt32(Row[0].ToString());
                eliminartracto();
                llenarListGrupo();
                llenarListTractos();
            }
        }

        public void eliminartracto()
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
                comm.CommandText = "spEliminarAsignacionGrupo";
                //enviamos los parametros del procedimiento almacenado
                comm.Parameters.AddWithValue("@id", idtracto);


                comm.ExecuteNonQuery();
                resultado = 1;
                conn.Close();

            }
            catch (Exception ex)
            {
                if (ex.Message == "No se pudo eliminar")
                {
                    resultado = 2;
                }
                else
                {
                    resultado = 0;
                }

                //throw;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void cmbgrupos_SelectionChangeCommitted(object sender, EventArgs e)
        {
            if (cmbgrupos.SelectedIndex != -1)
            {
                groupBox2.Enabled = true;
                llenarListGrupo();
                llenarListTractos();
            }
            else
            {
                lstBitacora.Items.Clear();
                lstTractos.Items.Clear();
                groupBox2.Enabled = false;
                MessageBox.Show("Seleccione un grupo en la lista");
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            FrmRegGrupo objreg = new FrmRegGrupo();
            objreg.ShowDialog();
            llenarComboGrupos();
            this.Show();
        }

        public void llenarListGrupo()
        {
            conn = new SqlConnection(objrutas.connstring);
            //abrir conexion con parametros previamente asignados
            conn.Open();
            //asignar comando de sql
            comm = new SqlCommand("spPopulateTractosGrupo", conn);
            //asignar conexion al comando
            comm.Connection = conn;
            //
            comm.CommandType = CommandType.StoredProcedure;
            comm.Parameters.AddWithValue("@grupo", Convert.ToInt32(cmbgrupos.SelectedValue));

            //
            adp = new SqlDataAdapter(comm);
            dtgrupo = new DataTable();
            adp.Fill(dtgrupo);
            conn.Close();

            lstBitacora.DataSource = null;
            lstBitacora.DataSource = dtgrupo;
            lstBitacora.ValueMember = "Id";
            lstBitacora.DisplayMember = "Tracto";
            lstBitacora.SelectedIndex = -1;
        }

        public void llenarListTractos()
        {
            conn = new SqlConnection(objrutas.connstring);
            //abrir conexion con parametros previamente asignados
            conn.Open();
            //asignar comando de sql
            comm = new SqlCommand("spPopulateTractosSinGrupo", conn);
            //asignar conexion al comando
            comm.Connection = conn;
            //
            comm.CommandType = CommandType.StoredProcedure;

            //
            adp = new SqlDataAdapter(comm);
            dttractos = new DataTable();
            adp.Fill(dttractos);
            conn.Close();

            lstTractos.DataSource = null;
            lstTractos.DataSource = dttractos;
            lstTractos.ValueMember = "Id";
            lstTractos.DisplayMember = "Tracto";
            lstTractos.SelectedIndex = -1;
        }
    }
}
