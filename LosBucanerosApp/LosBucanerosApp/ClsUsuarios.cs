using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace LosBucanerosApp
{
    class ClsUsuarios
    {
       public int  resultado;
        static public int existe;
        static public string fotoruta;
        private int idusuario;
        private int existefoto;
        private string nombre;
        private string apellido;
        private string usuario;
        private string pass;
        private string status;
        private string permisos;
        private string contador;
        private string fotonombre;
        private string msj;
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
        public string Usuario
        {
            get
            {
                return usuario;
            }

            set
            {
                usuario = value;
            }
        }
        public string Pass
        {
            get
            {
                return pass;
            }

            set
            {
                pass = value;
            }
        }
        public string Status
        {
            get
            {
                return status;
            }

            set
            {
                status = value;
            }
        }
        public string Permisos
        {
            get
            {
                return permisos;
            }

            set
            {
                permisos = value;
            }
        }
        public string Contador
        {
            get
            {
                return contador;
            }

            set
            {
                contador = value;
            }
        }
        public string Msj
        {
            get
            {
                return msj;
            }

            set
            {
                msj = value;
            }
        }
        public int Idusuario
        {
            get
            {
                return idusuario;
            }

            set
            {
                idusuario = value;
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

        public static int myInt = 0;

        private SqlConnection conn;
        private SqlCommand comm;
        public DataTable dt;
        public SqlDataAdapter adp;
        ClsRutas objrutas = new ClsRutas();
        public void login()
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
                comm.CommandText = "spLogin";
                //enviamos los parametros del procedimiento almacenado
                comm.Parameters.AddWithValue("@username", Usuario);
                comm.Parameters.AddWithValue("@passw", Pass);
                //declarar un reader , y ejecutar la consulta del procedimiento almacenado
                SqlDataReader myReader = comm.ExecuteReader();
       

                while (myReader.Read())
                {
                    Contador = myReader["contador"].ToString();
                    Nombre = myReader["Nombre"].ToString();
                    Apellido = myReader["Apellido"].ToString();
                    Permisos = myReader["Permiso"].ToString();


                }
                myReader.Close();
                conn.Close();

            }
            catch (Exception)
            {

                throw;
            }
        





           


        }
        public void insertuser()
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
                comm.CommandText = "spInsertUser";
                //enviamos los parametros del procedimiento almacenado
                comm.Parameters.AddWithValue("@name", Nombre);
                comm.Parameters.AddWithValue("@lastname", Apellido);
                comm.Parameters.AddWithValue("@username", Usuario);
                comm.Parameters.AddWithValue("@passw", Pass);
                comm.Parameters.AddWithValue("@status", Status);
                comm.Parameters.AddWithValue("@permiss", Permisos);
                comm.Parameters.AddWithValue("@foto", fotonombre);

                comm.ExecuteNonQuery();
              
                resultado = 1;
                conn.Close();

            }
            catch (Exception ex)
            {
                if (ex.Message == "Duplicado")
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
        public void deleteuser()
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
                comm.CommandText = "spDeleteUser";
                //enviamos los parametros del procedimiento almacenado
                comm.Parameters.AddWithValue("@id", Idusuario);
               
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
        public void updatetuser()
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
                comm.CommandText = "spUpdateUser";
                //enviamos los parametros del procedimiento almacenado
                comm.Parameters.AddWithValue("@id", idusuario);
                comm.Parameters.AddWithValue("@name", Nombre);
                comm.Parameters.AddWithValue("@lastname", Apellido);
                comm.Parameters.AddWithValue("@username", Usuario);
                comm.Parameters.AddWithValue("@passw", Pass);
                comm.Parameters.AddWithValue("@status", Status);
                comm.Parameters.AddWithValue("@permiss", Permisos);

                comm.ExecuteNonQuery();
                resultado = 1;

            }
            catch (Exception ex)
            {
                if (ex.Message == "Usuario Duplicado")
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
        public void updatetuserimage()
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
                comm.CommandText = "spUpdateUserImage";
                //enviamos los parametros del procedimiento almacenado
                comm.Parameters.AddWithValue("@id", idusuario);
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
        public void populateGridUser()
        {
            try
            { //establecer parametros de conexion
                conn = new SqlConnection(objrutas.connstring);
                //abrir conexion con parametros previamente asignados
                conn.Open();
                //asignar comando de sql
                comm = new SqlCommand("spPopulateGridUser",conn);
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





    }
}
