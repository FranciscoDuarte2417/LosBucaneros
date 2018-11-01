using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LosBucanerosApp
{
    class ClsFletes
    {
        private int resultado;
        private string fechaCreacion;
        private string horaCreacion;
        private string folioViaje;
        private string origen;
        private string destino;
        private string producto;
        private string tipoTemperatura;
        private string temperaturaProgramada;
        private string rangoTemperatura;
        private string tipoCarga;
        private int caja;
        private int operador;
        private string sellos;
        private string estatusCliente;
        private string estatusBucaneros;
        private string fechacita;
        private string horaCita;
        private string fechaSalida;
        private string horaSalida;
        private string fechaLlegada;
        private string horaLlegada;
        private string fechaDescarga;
        private string horaDescarga;
        private string usuario;
        private string comentarios;







        private SqlConnection conn;
        private SqlCommand comm;
        public DataTable dt;
        public SqlDataAdapter adp;
        ClsRutas objrutas = new ClsRutas();




        public int Resultado
        {
            get
            {
                return resultado;
            }

            set
            {
                resultado = value;
            }
        }

        public string FechaCreacion
        {
            get
            {
                return fechaCreacion;
            }

            set
            {
                fechaCreacion = value;
            }
        }

        public string HoraCreacion
        {
            get
            {
                return horaCreacion;
            }

            set
            {
                horaCreacion = value;
            }
        }

        public string FolioViaje
        {
            get
            {
                return folioViaje;
            }

            set
            {
                folioViaje = value;
            }
        }

        public string Origen
        {
            get
            {
                return origen;
            }

            set
            {
                origen = value;
            }
        }

        public string Destino
        {
            get
            {
                return destino;
            }

            set
            {
                destino = value;
            }
        }

        public string Producto
        {
            get
            {
                return producto;
            }

            set
            {
                producto = value;
            }
        }

        public string TipoTemperatura
        {
            get
            {
                return tipoTemperatura;
            }

            set
            {
                tipoTemperatura = value;
            }
        }

        public string TemperaturaProgramada
        {
            get
            {
                return temperaturaProgramada;
            }

            set
            {
                temperaturaProgramada = value;
            }
        }

        public string RangoTemperatura
        {
            get
            {
                return rangoTemperatura;
            }

            set
            {
                rangoTemperatura = value;
            }
        }

        public string TipoCarga
        {
            get
            {
                return tipoCarga;
            }

            set
            {
                tipoCarga = value;
            }
        }

        public int Caja
        {
            get
            {
                return caja;
            }

            set
            {
                caja = value;
            }
        }

        public int Operador
        {
            get
            {
                return operador;
            }

            set
            {
                operador = value;
            }
        }

        public string Sellos
        {
            get
            {
                return sellos;
            }

            set
            {
                sellos = value;
            }
        }

        public string EstatusCliente
        {
            get
            {
                return estatusCliente;
            }

            set
            {
                estatusCliente = value;
            }
        }

        public string EstatusBucaneros
        {
            get
            {
                return estatusBucaneros;
            }

            set
            {
                estatusBucaneros = value;
            }
        }

        public string Fechacita
        {
            get
            {
                return fechacita;
            }

            set
            {
                fechacita = value;
            }
        }

        public string HoraCita
        {
            get
            {
                return horaCita;
            }

            set
            {
                horaCita = value;
            }
        }

        public string FechaSalida
        {
            get
            {
                return fechaSalida;
            }

            set
            {
                fechaSalida = value;
            }
        }

        public string HoraSalida
        {
            get
            {
                return horaSalida;
            }

            set
            {
                horaSalida = value;
            }
        }

        public string FechaLlegada
        {
            get
            {
                return fechaLlegada;
            }

            set
            {
                fechaLlegada = value;
            }
        }

        public string HoraLlegada
        {
            get
            {
                return horaLlegada;
            }

            set
            {
                horaLlegada = value;
            }
        }

        public string FechaDescarga
        {
            get
            {
                return fechaDescarga;
            }

            set
            {
                fechaDescarga = value;
            }
        }

        public string HoraDescarga
        {
            get
            {
                return horaDescarga;
            }

            set
            {
                horaDescarga = value;
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

       

        public void insertarFlete()
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
                comm.CommandText = "spInsertViaje";
                //enviamos los parametros del procedimiento almacenado
                comm.Parameters.AddWithValue("@caja", Caja);
                comm.Parameters.AddWithValue("@folioviaje", FolioViaje);
                comm.Parameters.AddWithValue("@origen", Origen);
                comm.Parameters.AddWithValue("@destino", Destino);
                comm.Parameters.AddWithValue("@fechacreacion", FechaCreacion);
                comm.Parameters.AddWithValue("@horacreacion", HoraCreacion);
                comm.Parameters.AddWithValue("@producto", Producto);
                comm.Parameters.AddWithValue("@tipotemperatura", TipoTemperatura);
                comm.Parameters.AddWithValue("@temperaturaprogramada", TemperaturaProgramada);
                comm.Parameters.AddWithValue("@rangotemperatura", RangoTemperatura);
                comm.Parameters.AddWithValue("@tipocarga", TipoCarga);
                comm.Parameters.AddWithValue("@operador", Operador);
                comm.Parameters.AddWithValue("@sellos", Sellos);
               comm.Parameters.AddWithValue("@estatuscliente", EstatusCliente);
                comm.Parameters.AddWithValue("@estatusbucaneros", EstatusBucaneros);
                comm.Parameters.AddWithValue("@fechacita", Fechacita);
                comm.Parameters.AddWithValue("@horacita", HoraCita);
                comm.Parameters.AddWithValue("@fechasalida", FechaSalida);
                comm.Parameters.AddWithValue("@horasalida", HoraSalida);
                comm.Parameters.AddWithValue("@fechallegada", FechaLlegada);
                comm.Parameters.AddWithValue("@horallegada", HoraLlegada);
                comm.Parameters.AddWithValue("@fechadescarga", FechaDescarga);
                comm.Parameters.AddWithValue("@horadescarga", HoraDescarga);
                comm.Parameters.AddWithValue("@usuario", Usuario);


                comm.ExecuteNonQuery();

                resultado = 1;
                conn.Close();

            }
            catch (Exception ex)
            {
              
                
                    resultado = 0;
                

                //throw;
            }
        }

        
    }
}
