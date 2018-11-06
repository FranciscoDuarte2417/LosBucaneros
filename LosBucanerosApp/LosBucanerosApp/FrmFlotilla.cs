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
    public partial class FrmFlotilla : Form
    {
        public FrmFlotilla()
        {
            InitializeComponent();
        }

        public int resultado;
        ClsRutas objrutas = new ClsRutas();
        private SqlConnection conn;
        private SqlCommand comm;
        public DataTable dt;
        public DataTable dtgrupo;
        public DataTable dttractos;
        public SqlDataAdapter adp;
        public int idtracto = 0;

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

        private void lstBitacora_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cmbgrupos_SelectionChangeCommitted(object sender, EventArgs e)
        {
            if (cmbgrupos.SelectedIndex != -1)
            {
                llenarListGrupo();
                llenarListTractos();
                groupBox2.Enabled = true;
            }
            else
            {
                llenarcombocoordinador();
                groupBox2.Enabled = false;
            }
        }

        private void FrmFlotilla_Load(object sender, EventArgs e)
        {
            llenarcombocoordinador();
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
                comm.CommandText = "spInsertAsignacionCoordinador";
                //enviamos los parametros del procedimiento almacenado
                comm.Parameters.AddWithValue("@idtracto", idtracto);
                comm.Parameters.AddWithValue("@idcoordinador", Convert.ToInt32(cmbgrupos.SelectedValue.ToString()));

                comm.ExecuteNonQuery();
                resultado = 1;
                conn.Close();
                llenarListGrupo();
                llenarListTractos();

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
                comm.CommandText = "spDeleteAsignacionCoordinador";
                //enviamos los parametros del procedimiento almacenado
                comm.Parameters.AddWithValue("@id", idtracto);


                comm.ExecuteNonQuery();
                resultado = 1;
                conn.Close();
                llenarListGrupo();
                llenarListTractos();

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

        public void llenarcombocoordinador()
        {
            conn = new SqlConnection(objrutas.connstring);
            //abrir conexion con parametros previamente asignados
            conn.Open();
            //asignar comando de sql
            comm = new SqlCommand("spPopulateComboCoordinator", conn);
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
            cmbgrupos.ValueMember = "Id";
            cmbgrupos.DisplayMember = "Coordinador";
            cmbgrupos.SelectedIndex = -1;
        }

        public void llenarListGrupo()
        {
            conn = new SqlConnection(objrutas.connstring);
            //abrir conexion con parametros previamente asignados
            conn.Open();
            //asignar comando de sql
            comm = new SqlCommand("spTractoCordinador", conn);
            //asignar conexion al comando
            comm.Connection = conn;
            //
            comm.CommandType = CommandType.StoredProcedure;
            comm.Parameters.AddWithValue("@coordinador", Convert.ToInt32(cmbgrupos.SelectedValue));

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
            comm = new SqlCommand("spPopulateTractoSinCoordinador", conn);
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
