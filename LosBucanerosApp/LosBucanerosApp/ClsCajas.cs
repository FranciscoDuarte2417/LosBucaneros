using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LosBucanerosApp
{
    class ClsCajas
    {
        public int resultado;
        private int id;
        private string nomenclatura;
        private string nocaja;
        private string empresa;
        private string estatus;
        private string placa;
        private string comentarios;

        ClsRutas objrutas = new ClsRutas();
        private SqlConnection conn;
        private SqlCommand comm;
        public DataTable dt;
        public SqlDataAdapter adp;

        public string Nomenclatura
        {
            get
            {
                return nomenclatura;
            }

            set
            {
                nomenclatura = value;
            }
        }
        public string Nocaja
        {
            get
            {
                return nocaja;
            }

            set
            {
                nocaja = value;
            }
        }
        public string Placa
        {
            get
            {
                return placa;
            }

            set
            {
                placa = value;
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

        public void InsertCaja()
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
                comm.CommandText = "spInsertCaja";
                //enviamos los parametros del procedimiento almacenado
                comm.Parameters.AddWithValue("@nomenclatura", Nomenclatura);
                comm.Parameters.AddWithValue("@nocaja", Nocaja);
                comm.Parameters.AddWithValue("@empresa", Empresa);
                comm.Parameters.AddWithValue("@estatus", Estatus);
                comm.Parameters.AddWithValue("@placas", Empresa);
                comm.Parameters.AddWithValue("@comentarios", Estatus);


                comm.ExecuteNonQuery();
                resultado = 1;
                conn.Close();

            }
            catch (Exception ex)
            {
                if (ex.Message == "Tracto Duplicado")
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

        public void populateGridCajas()
        {
            try
            { //establecer parametros de conexion
                conn = new SqlConnection(objrutas.connstring);
                //abrir conexion con parametros previamente asignados
                conn.Open();
                //asignar comando de sql
                comm = new SqlCommand("spPopulateCajasFlete", conn);
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

    }
}
