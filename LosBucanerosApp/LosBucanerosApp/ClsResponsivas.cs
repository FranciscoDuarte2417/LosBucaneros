
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;


namespace LosBucanerosApp
{
    class ClsResponsivas
    {
        public int resultado;

        private int id;
        private int idAsignacion;
        private int idEquipo;
        private int idOperador;
        private string tipoResponsiva;
        private string total;
        private string descuentos;
        private string fecha;
        private string estatus;
        private string comentarios;
        private string tipoempleado;

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

        public int IdAsignacion
        {
            get
            {
                return idAsignacion;
            }

            set
            {
                idAsignacion = value;
            }
        }

        public int IdEquipo
        {
            get
            {
                return idEquipo;
            }

            set
            {
                idEquipo = value;
            }
        }

        public int IdOperador
        {
            get
            {
                return idOperador;
            }

            set
            {
                idOperador = value;
            }
        }

        public string TipoResponsiva
        {
            get
            {
                return tipoResponsiva;
            }

            set
            {
                tipoResponsiva = value;
            }
        }

        public string TipoEmpleado
        {
            get
            {
                return tipoempleado;
            }

            set
            {
                tipoempleado = value;
            }
        }

        public string Total
        {
            get
            {
                return total;
            }

            set
            {
                total = value;
            }
        }

        public string Descuentos
        {
            get
            {
                return descuentos;
            }

            set
            {
                descuentos = value;
            }
        }

        public string Fecha
        {
            get
            {
                return fecha;
            }

            set
            {
                fecha = value;
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
        public void insertResponsiva()
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
                comm.CommandText = "[spInsertResponsiva]";
                //enviamos los parametros del procedimiento almacenado
                comm.Parameters.AddWithValue("@idasignacion", IdAsignacion);
                comm.Parameters.AddWithValue("@idequipo", IdEquipo);
                comm.Parameters.AddWithValue("@idoperador", IdOperador);
                comm.Parameters.AddWithValue("@tiporesponsiva", TipoResponsiva);
                comm.Parameters.AddWithValue("@total", Total);
                comm.Parameters.AddWithValue("@descuentos", Descuentos);
                comm.Parameters.AddWithValue("@fecha", Fecha);
                comm.Parameters.AddWithValue("@estatus", Estatus);
                comm.Parameters.AddWithValue("@comentarios", Comentarios);
                comm.Parameters.AddWithValue("@tipoempleado", TipoEmpleado);


                 Id = Convert.ToInt32(comm.ExecuteScalar());



                //comm.ExecuteNonQuery();

                resultado = 1;
                conn.Close();

            }
            catch (Exception ex)
            {
                if (ex.Message == "Responsiva Duplicado")
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
        public void UpdateDeviceStatus()
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
                comm.CommandText = "[spUpdateDeviceEstatusByResponsiva]";
                //enviamos los parametros del procedimiento almacenado
                comm.Parameters.AddWithValue("@id", IdEquipo);


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
        public void UpdateAsignacionStatus()
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
                comm.CommandText = "[spUpdateAsignacionEstatusByResponsiva]";
                //enviamos los parametros del procedimiento almacenado
                comm.Parameters.AddWithValue("@id", IdAsignacion);


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
        public void populateComboOperadores()
        {
            try
            { //establecer parametros de conexion
                conn = new SqlConnection(objrutas.connstring);
                //abrir conexion con parametros previamente asignados
                conn.Open();
                //asignar comando de sql
                comm = new SqlCommand("[spPopulateComboOperadoresActivos]", conn);
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

        public void CargarComboAdministradores()
        {
            try
            { //establecer parametros de conexion
                conn = new SqlConnection(objrutas.connstring);
                //abrir conexion con parametros previamente asignados
                conn.Open();
                //asignar comando de sql
                comm = new SqlCommand("[spPopulateComboAdministrativosActivos]", conn);
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
        public void populateComboAsignaciones()
        {
            try
            { //establecer parametros de conexion
                conn = new SqlConnection(objrutas.connstring);
                //abrir conexion con parametros previamente asignados
                conn.Open();
                //asignar comando de sql
                comm = new SqlCommand("[spPopulateComboAsignacionesDisponibles]", conn);
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
        public void populateComboEquipos()
        {
            try
            { //establecer parametros de conexion
                conn = new SqlConnection(objrutas.connstring);
                //abrir conexion con parametros previamente asignados
                conn.Open();
                //asignar comando de sql
                comm = new SqlCommand("[spPopulateComboEquiposDisponibles]", conn);
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

        public void populateGridOperadores()
        {
            try
            { //establecer parametros de conexion
                conn = new SqlConnection(objrutas.connstring);
                //abrir conexion con parametros previamente asignados
                conn.Open();
                //asignar comando de sql

                comm = new SqlCommand("[spPopulateGridDriversBYId]", conn);
                //asignar conexion al comando
                comm.Connection = conn;
                //
                comm.CommandType = CommandType.StoredProcedure;
                comm.Parameters.AddWithValue("@id", IdOperador);
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

            public void populateGridAdministrativos()
        {
            try
            { //establecer parametros de conexion
                conn = new SqlConnection(objrutas.connstring);
                //abrir conexion con parametros previamente asignados
                conn.Open();
                //asignar comando de sql
              
                comm = new SqlCommand("[spPopulateGridAdministrativosBYId]", conn);
                //asignar conexion al comando
                comm.Connection = conn;
                //
                comm.CommandType = CommandType.StoredProcedure;
                comm.Parameters.AddWithValue("@id", IdOperador);
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

        public void IdResponsiva()
        {
            try
            { //establecer parametros de conexion
                conn = new SqlConnection(objrutas.connstring);
                //abrir conexion con parametros previamente asignados
                conn.Open();
                //asignar comando de sql

                comm = new SqlCommand("[spIdResponsiva]", conn);
                //asignar conexion al comando
                comm.Connection = conn;
                //
                comm.CommandType = CommandType.StoredProcedure;
                
                //
                adp = new SqlDataAdapter(comm);
                dt = new DataTable();
                adp.Fill(dt);
                DataRow row = dt.Rows[0];
                id = Convert.ToInt32(row[0].ToString());


            }
            catch (Exception)
            {

                throw;
            }
        }
        public void populateGridEquipos()
        {
            try
            { //establecer parametros de conexion
                conn = new SqlConnection(objrutas.connstring);
                //abrir conexion con parametros previamente asignados
                conn.Open();
                //asignar comando de sql

                comm = new SqlCommand("[spPopulateGriddEVICESBYId]", conn);
                //asignar conexion al comando
                comm.Connection = conn;
                //
                comm.CommandType = CommandType.StoredProcedure;
                comm.Parameters.AddWithValue("@id", IdEquipo);
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
        public void populateGridAsignaciones()
        {
            try
            { //establecer parametros de conexion
                conn = new SqlConnection(objrutas.connstring);
                //abrir conexion con parametros previamente asignados
                conn.Open();
                //asignar comando de sql

                comm = new SqlCommand("spPopulateGridAsignacionesBYId", conn);
                //asignar conexion al comando
                comm.Connection = conn;
                //
                comm.CommandType = CommandType.StoredProcedure;
                comm.Parameters.AddWithValue("@id", IdAsignacion);
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
        public void populateGridResponsivasActivas(string tipoempleado)
        {
            try
            { //establecer parametros de conexion
                conn = new SqlConnection(objrutas.connstring);
                //abrir conexion con parametros previamente asignados
                conn.Open();
                //asignar comando de sql

                comm = new SqlCommand("[spPopulateGridResponsivasActivas]", conn);
                //asignar conexion al comando
                comm.Connection = conn;
                //
                comm.CommandType = CommandType.StoredProcedure;
                comm.Parameters.AddWithValue("@tipoempleado", tipoempleado);
              
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
