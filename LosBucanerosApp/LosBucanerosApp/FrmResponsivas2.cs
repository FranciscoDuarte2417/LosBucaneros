using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LosBucanerosApp
{
    public partial class FrmResponsivas2 : Form
    {
        string Nombre, Apellido, Permiso,Tipoempleado;
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
                    int id = Convert.ToInt32(selectedRow.Cells["Id"].Value);

                    FrmDetallesResponsiva objdetalles = new FrmDetallesResponsiva(id, Nombre, Apellido, Permiso,Tipoempleado);
                    objdetalles.Show();
                }

                if (cell.Value.ToString() == "Agregar")
                {
                    int selectedrowindex = dgvResponsivas.SelectedCells[0].RowIndex;
                    DataGridViewRow selectedRow = dgvResponsivas.Rows[selectedrowindex];
                    int id = Convert.ToInt32(selectedRow.Cells["Id"].Value);


                    FrmAmazonPhoto photo = new FrmAmazonPhoto(id.ToString(),Tipoempleado);
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
            //DialogResult X = MessageBox.Show("¿El operador sera dado de baja?","Baja Responsiva",MessageBoxButtons.YesNoCancel);
            //if (X == DialogResult.Yes)
            //{
            //    DialogResult X = MessageBox.Show("¿El operador sera dado de baja?", "Baja Responsiva", MessageBoxButtons.YesNoCancel);
            //}
            //else if (X == DialogResult.No)
            //{

            //}
            //else if(X == DialogResult.Cancel)
            //{

            //}
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

        string id = "";
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (dgvResponsivas.SelectedCells.Count > 0)
                {
                    int selectedrowindex = dgvResponsivas.SelectedCells[0].RowIndex;

                    DataGridViewRow selectedRow = dgvResponsivas.Rows[selectedrowindex];
                    id = Convert.ToString(selectedRow.Cells["Id"].Value);
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
    }
}
