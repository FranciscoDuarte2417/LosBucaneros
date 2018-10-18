using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace LosBucanerosApp
{
    class ClsCoordinadores
    {

        public int resultado;
        static public int existe;
        static public string fotoruta;

        private int idcoordinador;
        private string nombre;
        private string nombre2;
        private string apellido;
        private string apellido2;
        private string uce;
        private string estatus;
        private string fotonombre;
        private int existefoto; 

        public int Idcoordinador
        {
            get
            {
                return idcoordinador;
            }

            set
            {
                idcoordinador = value;
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
        private SqlConnection conn;
        private SqlCommand comm;
        public DataTable dt;
        public SqlDataAdapter adp;
        ClsRutas objrutas = new ClsRutas();

        public void insertcoordinator()
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
                comm.CommandText = "spInsertCoordinator";
                //enviamos los parametros del procedimiento almacenado
                comm.Parameters.AddWithValue("@nombre", Nombre);
                comm.Parameters.AddWithValue("@nombre2", Nombre2);
                comm.Parameters.AddWithValue("@apellido", Apellido);
                comm.Parameters.AddWithValue("@apellido2", Apellido2);
                comm.Parameters.AddWithValue("@uce", Uce);
                comm.Parameters.AddWithValue("@estatus", Estatus);
                comm.Parameters.AddWithValue("@foto", Fotonombre);

                comm.ExecuteNonQuery();

                resultado = 1;
                conn.Close();

            }
            catch (Exception ex)
            {
                if (ex.Message == "Coordinador Duplicado")
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
        public void populateGridCoordinator()
        {
            try
            { //establecer parametros de conexion
                conn = new SqlConnection(objrutas.connstring);
                //abrir conexion con parametros previamente asignados
                conn.Open();
                //asignar comando de sql
                comm = new SqlCommand("spPopulateGridCoordinator", conn);
                //asignar conexion al comando
                comm.Connection = conn;
                //
                comm.CommandType = CommandType.StoredProcedure;

                //
                adp = new SqlDataAdapter(comm);
                dt = new DataTable();
                adp.Fill(dt);


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
        public void deleteCoordinators()
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
                comm.CommandText = "spDeleteCoordinator";
                //enviamos los parametros del procedimiento almacenado
                comm.Parameters.AddWithValue("@id",Idcoordinador);

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

        public void updateCoordinator()
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
                comm.CommandText = "spUpdateCoordinator";
                //enviamos los parametros del procedimiento almacenado
                comm.Parameters.AddWithValue("@id", idcoordinador);
                comm.Parameters.AddWithValue("@nombre", Nombre);
                comm.Parameters.AddWithValue("@nombre2", Nombre2);
                comm.Parameters.AddWithValue("@apellido", Apellido);
                comm.Parameters.AddWithValue("@apellido2", Apellido2);
                comm.Parameters.AddWithValue("@uce", Uce);
                comm.Parameters.AddWithValue("@estatus", Estatus);
                


                comm.ExecuteNonQuery();
                resultado = 1;

            }
            catch (Exception ex)
            {
                if (ex.Message == "Coordinador Duplicado")
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
        public void updateCoordinatorimage()
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
                comm.CommandText = "spUpdateCoordinatorImage";
                //enviamos los parametros del procedimiento almacenado
                comm.Parameters.AddWithValue("@id", idcoordinador);
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
