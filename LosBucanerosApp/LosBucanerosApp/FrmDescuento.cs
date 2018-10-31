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
    public partial class FrmDescuento : Form
    {
        string Id, Operador,Tiporesponsiva;
        private SqlConnection conn;
        private SqlCommand comm;
        public DataTable dt;
        public SqlDataAdapter adp;
        ClsRutas objrutas = new ClsRutas();

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (txtPrecioBucaneros.Text != "" && txtmotivo.Text != "" && comboBox1.SelectedIndex != -1)
            {
                string rentaa;
                string rentaaux1 = txtPrecioBucaneros.Text.Substring(2, 2);
                if (rentaaux1 == " " || rentaaux1 == "00" || rentaaux1 == "  ")
                {
                    rentaa = txtPrecioBucaneros.Text.Substring(5, txtPrecioBucaneros.TextLength - 5);
                }

                else if (rentaaux1 == "01" || rentaaux1 == "02" || rentaaux1 == "03" || rentaaux1 == "04" || rentaaux1 == "05" || rentaaux1 == "06" || rentaaux1 == "07" || rentaaux1 == "08" || rentaaux1 == "09" || rentaaux1 == " 1" || rentaaux1 == " 2" || rentaaux1 == " 3" || rentaaux1 == " 4" || rentaaux1 == " 5" || rentaaux1 == " 6" || rentaaux1 == " 7" || rentaaux1 == " 8" || rentaaux1 == " 9")
                {
                    rentaa = txtPrecioBucaneros.Text.Substring(3, txtPrecioBucaneros.TextLength - 3);
                }
                else
                {
                    rentaa = txtPrecioBucaneros.Text.Substring(1, txtPrecioBucaneros.TextLength - 1);
                }

                try
                {
                    string Tipodescuento = "", Fecha = "", Totaldescuento = "", Comentario = "";
                    Tipodescuento = comboBox1.Text;
                    Fecha = DateTime.Today.ToShortDateString();
                    Totaldescuento = rentaa;
                    Comentario = txtmotivo.Text;

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
                    comm.CommandText = "spInsertDescuento";
                    //enviamos los parametros del procedimiento almacenado
                    comm.Parameters.AddWithValue("@idresponsiva", Id);
                    comm.Parameters.AddWithValue("@tipodescuento", Tipodescuento);
                    comm.Parameters.AddWithValue("@totaldescuento", Totaldescuento);
                    comm.Parameters.AddWithValue("@fecha", Fecha);
                    comm.Parameters.AddWithValue("@Comentarios", Comentario);

                    comm.ExecuteNonQuery();
                    conn.Close();
                    this.Close();
                }
                catch (Exception)
                {

                    throw;
                }
            }
            
        }

        public FrmDescuento(string id,string operador,string tiporesponsiva)
        {
            InitializeComponent();
            Id = id;
            Operador = operador;
            Tiporesponsiva = tiporesponsiva;
            txtempleado.Text = Operador;
            txtid.Text = id;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }
    }
}
