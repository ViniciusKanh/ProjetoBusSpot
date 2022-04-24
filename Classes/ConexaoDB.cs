using System.Data;
using System.Data.SqlTypes;
using System.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Classes.Endereco;


namespace Classes
{
   public static class ConexaoDB
    {
        public static SqlConnection conexao;
      	        
   public static string cn = "Data Source=VINICIUS-SANTOS\\VINICIUSKHAN;Initial Catalog=BusSpot;Persist Security Info=True;User ID=sa;Password=intel";

        private static SqlConnection ConexaoBanco()
        {
            conexao = new SqlConnection("Data Source=VINICIUS-SANTOS\\VINICIUSKHAN;Initial Catalog=BusSpot;Persist Security Info=True;User ID=sa;Password=intel");
            
                    return conexao;
        }
            public static DataTable dql(string sql)//Data Query Language
        {
            SqlDataAdapter da = null;
            DataTable dt = new DataTable();
            try
            {
                var vcon = ConexaoBanco();
                var cmd = vcon.CreateCommand();
                cmd.CommandText = sql;
                da = new SqlDataAdapter(cmd.CommandText, vcon);
                da.Fill(dt);
                vcon.Close();
                return dt;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

    }

}
	
         