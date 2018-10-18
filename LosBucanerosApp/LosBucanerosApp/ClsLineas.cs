using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace LosBucanerosApp
{
    class ClsLineas
    {
        public int resultado;
        static public int existe;
        static public string fotoruta;

        private int id;
        private string region;
        private string cuentapadre;
        private string cuenta;
        private string compania;
        private string telefono;
        private string plan;
        private string renta;
        private string fechaInicio;
        private string fechaTermino;
        private string comentarios;
        private string duracion;
        private string estatus;
        private string fotonombre;
        private int existefoto;

        private SqlConnection conn;
        private SqlCommand comm;
        public DataTable dt;
        public SqlDataAdapter adp;
        ClsRutas objrutas = new ClsRutas();

        public int Id
        {
            get
            {
                return id;
            }

            set
            {
                id = value;
            }
        }

        public string Region
        {
            get
            {
                return region;
            }

            set
            {
                region = value;
            }
        }

        public string Cuenta
        {
            get
            {
                return cuenta;
            }

            set
            {
                cuenta = value;
            }
        }

        public string Compania
        {
            get
            {
                return compania;
            }

            set
            {
                compania = value;
            }
        }

        public string Telefono
        {
            get
            {
                return telefono;
            }

            set
            {
                telefono = value;
            }
        }

        public string Plan
        {
            get
            {
                return plan;
            }

            set
            {
                plan = value;
            }
        }

        public string Renta
        {
            get
            {
                return renta;
            }

            set
            {
                renta = value;
            }
        }

        public string FechaInicio
        {
            get
            {
                return fechaInicio;
            }

            set
            {
                fechaInicio = value;
            }
        }

        public string FechaTermino
        {
            get
            {
                return fechaTermino;
            }

            set
            {
                fechaTermino = value;
            }
        }

        public string Duracion
        {
            get
            {
                return duracion;
            }

            set
            {
                duracion = value;
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

        public string Cuentapadre
        {
            get
            {
                return cuentapadre;
            }

            set
            {
                cuentapadre = value;
            }
        }

        public string Comentarios
        {
            get
            {
                return comentarios;
            }

            set
            {
                comentarios = value;
            }
        }

        public void insertLine()
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
                comm.CommandText = "[spInsertLine]";
                //enviamos los parametros del procedimiento almacenado
                comm.Parameters.AddWithValue("@region", Region);
                comm.Parameters.AddWithValue("@cuentapadre", Cuentapadre);
                comm.Parameters.AddWithValue("@cuenta", Cuenta);
                comm.Parameters.AddWithValue("@compania", Compania);
                comm.Parameters.AddWithValue("@telefono", Telefono);
                comm.Parameters.AddWithValue("@plan", Plan);
                comm.Parameters.AddWithValue("@renta", Renta);
                comm.Parameters.AddWithValue("@fechainicio", FechaInicio);
                comm.Parameters.AddWithValue("@fechatermino", FechaTermino);
                comm.Parameters.AddWithValue("@duracion", Duracion);
                comm.Parameters.AddWithValue("@estatus", Estatus);
                comm.Parameters.AddWithValue("@comentarios", Comentarios);



                comm.ExecuteNonQuery();

                resultado = 1;
                conn.Close();

            }
            catch (Exception ex)
            {
                if (ex.Message == "Linea Duplicado")
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

        public void populateGridLines()
        {
            try
            { //establecer parametros de conexion
                conn = new SqlConnection(objrutas.connstring);
                //abrir conexion con parametros previamente asignados
                conn.Open();
                //asignar comando de sql
                comm = new SqlCommand("[spPopulateGridLines]", conn);
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
        public void populateGridLinesDisponibles()
        {
            try
            { //establecer parametros de conexion
                conn = new SqlConnection(objrutas.connstring);
                //abrir conexion con parametros previamente asignados
                conn.Open();
                //asignar comando de sql
                comm = new SqlCommand("[spPopulateGridLinesDisponibles]", conn);
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
            
        }
        public void populateGridLinesActivo()
        {
            try
            { //establecer parametros de conexion
                conn = new SqlConnection(objrutas.connstring);
                //abrir conexion con parametros previamente asignados
                conn.Open();
                //asignar comando de sql
                comm = new SqlCommand("[spPopulateGridLinesActivo]", conn);
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
        public void populateGridLinesBaja()
        {
            try
            { //establecer parametros de conexion
                conn = new SqlConnection(objrutas.connstring);
                //abrir conexion con parametros previamente asignados
                conn.Open();
                //asignar comando de sql
                comm = new SqlCommand("[spPopulateGridLinesBaja]", conn);
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
        public void updateLine()
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
                //nombre del procedimiento [spUpdateDevice]
                comm.CommandText = "[spUpdateLine]";
                //enviamos los parametros del procedimiento almacenado
                comm.Parameters.AddWithValue("@id", Id);
                comm.Parameters.AddWithValue("@region", Region);
                comm.Parameters.AddWithValue("@cuentapadre", Cuentapadre);
                comm.Parameters.AddWithValue("@cuenta", Cuenta);
                comm.Parameters.AddWithValue("@compania", Compania);
                comm.Parameters.AddWithValue("@telefono", Telefono);
                comm.Parameters.AddWithValue("@plan", Plan);
                comm.Parameters.AddWithValue("@renta", Renta);
                comm.Parameters.AddWithValue("@fechainicio", FechaInicio);
                comm.Parameters.AddWithValue("@fechatermino", FechaTermino);
                comm.Parameters.AddWithValue("@duracion", Duracion);
                comm.Parameters.AddWithValue("@estatus", Estatus);
                comm.Parameters.AddWithValue("@comentarios", Comentarios);


                comm.ExecuteNonQuery();
                resultado = 1;

            }
            catch (Exception ex)
            {
                if (ex.Message == "Equipo Duplicado")
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

        public void deleteLine()
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
                comm.CommandText = "[spUpdateLineEstatus]";
                //enviamos los parametros del procedimiento almacenado
                comm.Parameters.AddWithValue("@id", Id);
                comm.Parameters.AddWithValue("@Comentarios", comentarios);

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
