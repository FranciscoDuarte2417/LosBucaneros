using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace LosBucanerosApp
{
    class ClsAdministrativos
    {
        public int resultado;
        static public int existe;
        static public string fotoruta;

        private int idadministrativo;
             private string noEmpleado;
        private string nombre;
        private string nombre2;
        private string empresa;
        private string uce;
        private string apellido;
        private string apellido2;
        private string puesto;
        private string estatus;
        private string fotonombre;
        private int existefoto;


      
        private SqlConnection conn;
        private SqlCommand comm;
        public DataTable dt;
        public SqlDataAdapter adp;
        ClsRutas objrutas = new ClsRutas();

        public int Idadministrativo
        {
            get
            {
                return idadministrativo;
            }

            set
            {
                idadministrativo = value;
            }
        }

        public string Nombre
        {
            get
            {
                return nombre;
            }

            set
            {
                nombre = value;
            }
        }

        public string Nombre2
        {
            get
            {
                return nombre2;
            }

            set
            {
                nombre2 = value;
            }
        }

        public string Empresa
        {
            get
            {
                return empresa;
            }

            set
            {
                empresa = value;
            }
        }

        public string Apellido
        {
            get
            {
                return apellido;
            }

            set
            {
                apellido = value;
            }
        }

        public string Apellido2
        {
            get
            {
                return apellido2;
            }

            set
            {
                apellido2 = value;
            }
        }

        public string Puesto
        {
            get
            {
                return puesto;
            }

            set
            {
                puesto = value;
            }
        }

        public string Estatus
        {
            get
            {
                return estatus;
            }

            set
            {
                estatus = value;
            }
        }

        public string Fotonombre
        {
            get
            {
                return fotonombre;
            }

            set
            {
                fotonombre = value;
            }
        }

        public int Existefoto
        {
            get
            {
                return existefoto;
            }

            set
            {
                existefoto = value;
            }
        }

        public string NoEmpleado
        {
            get
            {
                return noEmpleado;
            }

            set
            {
                noEmpleado = value;
            }
        }

        public string Uce
        {
            get
            {
                return uce;
            }

            set
            {
                uce = value;
            }
        }

        public void insertAdministrative()
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
                comm.CommandText = "spInsertAdministrative";
                //enviamos los parametros del procedimiento almacenado
                comm.Parameters.AddWithValue("@noempleado", NoEmpleado);
                comm.Parameters.AddWithValue("@nombre", Nombre);
                comm.Parameters.AddWithValue("@nombre2", Nombre2);
                comm.Parameters.AddWithValue("@apellido", Apellido);
                comm.Parameters.AddWithValue("@apellido2", Apellido2);
                comm.Parameters.AddWithValue("@empresa", Empresa);
                comm.Parameters.AddWithValue("@uce", Uce);
                comm.Parameters.AddWithValue("@puesto", Puesto);
                comm.Parameters.AddWithValue("@estatus", Estatus);
                comm.Parameters.AddWithValue("@foto", Fotonombre);

                comm.ExecuteNonQuery();

                resultado = 1;
                conn.Close();

            }
            catch (Exception ex)
            {
                if (ex.Message == "Administrativo Duplicado")
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

        public void populateGridAdministratives()
        {
            try
            { //establecer parametros de conexion
                conn = new SqlConnection(objrutas.connstring);
                //abrir conexion con parametros previamente asignados
                conn.Open();
                //asignar comando de sql
                comm = new SqlCommand("spPopulateGridAdministratives", conn);
                //asignar conexion al comando
                comm.Connection = conn;
                //
                comm.CommandType = CommandType.StoredProcedure;

                //
                adp = new SqlDataAdapter(comm);
                dt = new DataTable();
                adp.Fill(dt);
                conn.Close();

            }
            catch (Exception)
            {

                throw;
            }


            //DataTable dt = new DataTable();
            //SqlConnection myConn = new SqlConnection("Data Source=SERVER-SQL1;Initial Catalog=OPSystem;Integrated Security=True");
            //myConn.Open();
            //SqlCommand myCmd = new SqlCommand("spCustomers", myConn);
            //myCmd.CommandType = CommandType.StoredProcedure;
            //SqlDataAdapter da = new SqlDataAdapter(myCmd);
            //da.Fill(dt);
            //dataGridView1.DataSource = dt;
            //dataGridView1.DataBind();

        }

        public void deleteAdministratives()
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
                comm.CommandText = "spDeleteAdministrative";
                //enviamos los parametros del procedimiento almacenado
                comm.Parameters.AddWithValue("@id", Idadministrativo);

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

        public void TelefonoAdministratives(string estado)
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
                comm.CommandText = "spTelefonoAdministrative";
                //enviamos los parametros del procedimiento almacenado
                comm.Parameters.AddWithValue("@id", Idadministrativo);
                comm.Parameters.AddWithValue("@estado", estado);

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

        public void updateAdministrative()
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
                comm.CommandText = "spUpdateAdministrative";
                //enviamos los parametros del procedimiento almacenado
                comm.Parameters.AddWithValue("@id", idadministrativo);
                comm.Parameters.AddWithValue("@noempleado", noEmpleado);
                comm.Parameters.AddWithValue("@nombre", Nombre);
                comm.Parameters.AddWithValue("@nombre2", Nombre2);
                comm.Parameters.AddWithValue("@apellido", Apellido);
                comm.Parameters.AddWithValue("@apellido2", Apellido2);
                comm.Parameters.AddWithValue("@empresa", Empresa);
                comm.Parameters.AddWithValue("@uce", Uce);
                comm.Parameters.AddWithValue("@puesto", Puesto);
                comm.Parameters.AddWithValue("@estatus", Estatus);


                comm.ExecuteNonQuery();
                resultado = 1;

            }
            catch (Exception ex)
            {
                if (ex.Message == "Administrativo Duplicado")
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

        public void updateAdministrativeimage()
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
                comm.CommandText = "spUpdateAdministrativeImage";
                //enviamos los parametros del procedimiento almacenado
                comm.Parameters.AddWithValue("@id", Idadministrativo);
                comm.Parameters.AddWithValue("@foto", Fotonombre);


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

    }
}
