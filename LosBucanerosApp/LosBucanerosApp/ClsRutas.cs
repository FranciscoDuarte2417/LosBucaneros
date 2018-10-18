using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;


namespace LosBucanerosApp
{
    class ClsRutas
    {
        public string connstring = "Server=losbucaneros.clkm3ykxjjdd.us-east-1.rds.amazonaws.com;Database=DBLosBucaneros;User ID=sa;Password=LosBucaneros2018;";
        public string msj;
        private SqlConnection conn;
      //  private SqlCommand comm;

        public void TestOpenConnect()
        {
            try
            {
                conn = new SqlConnection(connstring);
                conn.Open();
                msj = "1";
                conn.Close();


            }
            catch (Exception ex)
            {

                msj = "0";
            }
           
        
        }
    }
}
