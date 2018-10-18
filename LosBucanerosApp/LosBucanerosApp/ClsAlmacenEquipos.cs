using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace LosBucanerosApp
{
    class ClsAlmacenEquipos
    {

        public int resultado;
        static public int existe;
        static public string fotoruta;


        private int id;
        private string imei;
        private string marca;
        private string modelo;
        private string nombre;
        private string compania;
        private string cargador;
        private string cable;
        private string audifonos;
        private string protector;
        private string esNuevo;
        private string noFactura;
        private string autorizo;
        private string precioPublico;
        private string precioBucaneros;
        private string comentarios;
        private string estatus;
        private string fotonombre;
        private string equipopagado;
        private string meses;
        private string pagomensual;
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

        public string Imei
        {
            get
            {
                return imei;
            }

            set
            {
                imei = value;
            }
        }

        public string Equipopagado
        {
            get
            {
                return equipopagado;
            }

            set
            {
                equipopagado = value;
            }
        }

        public string Meses
        {
            get
            {
                return meses;
            }

            set
            {
                meses = value;
            }
        }

        public string Pagomensual
        {
            get
            {
                return pagomensual;
            }

            set
            {
                pagomensual = value;
            }
        }

        public string Marca
        {
            get
            {
                return marca;
            }

            set
            {
                marca = value;
            }
        }

        public string Modelo
        {
            get
            {
                return modelo;
            }

            set
            {
                modelo = value;
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

        public string Cargador
        {
            get
            {
                return cargador;
            }

            set
            {
                cargador = value;
            }
        }

        public string Cable
        {
            get
            {
                return cable;
            }

            set
            {
                cable = value;
            }
        }

        public string Audifonos
        {
            get
            {
                return audifonos;
            }

            set
            {
                audifonos = value;
            }
        }

        public string Protector
        {
            get
            {
                return protector;
            }

            set
            {
                protector = value;
            }
        }

        public string EsNuevo
        {
            get
            {
                return esNuevo;
            }

            set
            {
                esNuevo = value;
            }
        }

        public string NoFactura
        {
            get
            {
                return noFactura;
            }

            set
            {
                noFactura = value;
            }
        }

        public string Autorizo
        {
            get
            {
                return autorizo;
            }

            set
            {
                autorizo = value;
            }
        }

        public string PrecioPublico
        {
            get
            {
                return precioPublico;
            }

            set
            {
                precioPublico = value;
            }
        }

        public string PrecioBucaneros
        {
            get
            {
                return precioBucaneros;
            }

            set
            {
                precioBucaneros = value;
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


        public void insertDevices()
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
                comm.CommandText = "spInsertDevice";
                //enviamos los parametros del procedimiento almacenado
                comm.Parameters.AddWithValue("@imei", Imei);
                comm.Parameters.AddWithValue("@marca", Marca);
                comm.Parameters.AddWithValue("@modelo", Modelo);
                comm.Parameters.AddWithValue("@nombre", Nombre);
                comm.Parameters.AddWithValue("@compania", Compania);
                comm.Parameters.AddWithValue("@cargador", Cargador);
                comm.Parameters.AddWithValue("@cable", Cable);
                comm.Parameters.AddWithValue("@audifonos", Audifonos);
                comm.Parameters.AddWithValue("@protector", Protector);
                comm.Parameters.AddWithValue("@esnuevo", EsNuevo);
                comm.Parameters.AddWithValue("@nofactura", NoFactura);
                comm.Parameters.AddWithValue("@autoriza", Autorizo);
                comm.Parameters.AddWithValue("@preciopublico", PrecioPublico);
                comm.Parameters.AddWithValue("@preciobucaneros", PrecioBucaneros);
                comm.Parameters.AddWithValue("@comentarios", Comentarios);
                comm.Parameters.AddWithValue("@estatus", Estatus);
                comm.Parameters.AddWithValue("@foto", Fotonombre);
                comm.Parameters.AddWithValue("@Equipopagado", Equipopagado);
                comm.Parameters.AddWithValue("@Meses", Meses);
                comm.Parameters.AddWithValue("@PagoMensual", Pagomensual);
                            

                comm.ExecuteNonQuery();

                resultado = 1;
                conn.Close();

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
        public void updateDevice()
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
                comm.CommandText = "spUpdateDevice";
                //enviamos los parametros del procedimiento almacenado
                comm.Parameters.AddWithValue("@id", Id);
                comm.Parameters.AddWithValue("@imei", Imei);
                comm.Parameters.AddWithValue("@marca", Marca);
                comm.Parameters.AddWithValue("@modelo", Modelo);
                comm.Parameters.AddWithValue("@nombre", Nombre);
                comm.Parameters.AddWithValue("@compania", Compania);
                comm.Parameters.AddWithValue("@cargador", Cargador);
                comm.Parameters.AddWithValue("@cable", Cable);
                comm.Parameters.AddWithValue("@audifonos", Audifonos);
                comm.Parameters.AddWithValue("@protector", Protector);
                comm.Parameters.AddWithValue("@esnuevo", EsNuevo);
                comm.Parameters.AddWithValue("@nofactura", NoFactura);
                comm.Parameters.AddWithValue("@autoriza", Autorizo);
                comm.Parameters.AddWithValue("@preciopublico", PrecioPublico);
                comm.Parameters.AddWithValue("@preciobucaneros", PrecioBucaneros);
                comm.Parameters.AddWithValue("@comentarios", Comentarios);
                comm.Parameters.AddWithValue("@estatus", "disponible");
                comm.Parameters.AddWithValue("@Equipopagado", Equipopagado);
                comm.Parameters.AddWithValue("@Meses", Meses);
                comm.Parameters.AddWithValue("@PagoMensual", Pagomensual);


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
        public void populateGridDevices()
        {
            try
            { //establecer parametros de conexion
                conn = new SqlConnection(objrutas.connstring);
                //abrir conexion con parametros previamente asignados
                conn.Open();
                //asignar comando de sql
                comm = new SqlCommand("spPopulateGridDevices", conn);
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
        public void updateDeviceimage()
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
                comm.CommandText = "spUpdateDeviceImage";
                //enviamos los parametros del procedimiento almacenado
                comm.Parameters.AddWithValue("@id", Id);
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
        public void deleteDevice()
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
                comm.CommandText = "spUpdateDeviceEstatus";
                //enviamos los parametros del procedimiento almacenado
                comm.Parameters.AddWithValue("@id", Id);
                comm.Parameters.AddWithValue("@Comentarios",Comentarios);

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
