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
    public partial class FrmRegGrupo : Form
    {
        public FrmRegGrupo()
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

        private void FrmRegGrupo_Load(object sender, EventArgs e)
        {

        }

        private void btnregistrar_Click(object sender, EventArgs e)
        {
            if (txtnombregrupo.Text != "")
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
                    comm.CommandText = "spInsertGrupo";
                    //enviamos los parametros del procedimiento almacenado
                    comm.Parameters.AddWithValue("@grupo", txtnombregrupo.Text);
                    comm.Parameters.AddWithValue("@comentarios", txtcomentario.Text);

                    comm.ExecuteNonQuery();
                    resultado = 1;
                    conn.Close();
                    txtcomentario.Text = "";
                    txtnombregrupo.Text = "";
                    this.Close();
                }
                catch (Exception ex)
                {
                    if (ex.Message == "No se puede registrar")
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
        }
    }
}
