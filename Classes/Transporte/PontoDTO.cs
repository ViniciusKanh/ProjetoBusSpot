using System.Data;
using System.Data.SqlTypes;
using System.Data.SqlClient;

namespace Classes.Transporte
{

	public class PontoDTO
	{
		public int ID { get; set; }
		public String Tipo { get;  set; }

		public int ID_Parada { get; set; }

		public String txtBuscar { get; set; }

		public PontoDTO()
        {
        }

        public string Incluir_Ponto(PontoDTO ponto)
		{
			string Resp;

			SqlConnection Sqlcon = new SqlConnection();

			try
			{
				Sqlcon.ConnectionString = ConexaoDB.cn;
				Sqlcon.Open();
				SqlCommand SqlCmd = new SqlCommand();
				SqlCmd.Connection = Sqlcon;
				SqlCmd.CommandText = "Proc_Inserir_Ponto";
				SqlCmd.CommandType = CommandType.StoredProcedure;

				SqlParameter ParTipo_Ponto = new SqlParameter();
				ParTipo_Ponto.ParameterName = "@Tipo";
				ParTipo_Ponto.SqlDbType = SqlDbType.VarChar;
				ParTipo_Ponto.Size = 50;
				ParTipo_Ponto.Value = Tipo;
				SqlCmd.Parameters.Add(ParTipo_Ponto);

				SqlParameter ParID_Parada = new SqlParameter();
				ParID_Parada.ParameterName = "@ID";
				ParID_Parada.SqlDbType = SqlDbType.Int;
				ParID_Parada.Value = ID_Parada;
				SqlCmd.Parameters.Add(ParID_Parada);

				Resp = SqlCmd.ExecuteNonQuery() == 1 ? "OK" : "Ponto Não Inserido";



			}
			catch (Exception error)
			{

				Resp = error.Message;
			}

			finally { if (Sqlcon.State == ConnectionState.Open) Sqlcon.Close(); }

			return Resp;

		}

		public DataTable Mostrar_Ponto()
		{
			DataTable DtResultado = new DataTable("Ponto");

			SqlConnection Sqlcon = new SqlConnection();

			try
			{
				Sqlcon.ConnectionString = ConexaoDB.cn;
				SqlCommand SqlCmd = new SqlCommand();
				SqlCmd.Connection = Sqlcon;
				SqlCmd.CommandText = "Proc_Mostrar_Ponto";
				SqlCmd.CommandType = CommandType.StoredProcedure;
				SqlDataAdapter SqlDat = new SqlDataAdapter(SqlCmd);
				SqlDat.Fill(DtResultado);


			}
			catch (Exception error)
			{
				DtResultado = null;

			}

			finally { if (Sqlcon.State == ConnectionState.Open) Sqlcon.Close(); }

			return DtResultado;



		}

		///  
		public string Remover_Ponto(PontoDTO ponto)
		{
			string Resp;

			SqlConnection Sqlcon = new SqlConnection();

			try
			{
				Sqlcon.ConnectionString = ConexaoDB.cn;
				Sqlcon.Open();
				SqlCommand SqlCmd = new SqlCommand();
				SqlCmd.Connection = Sqlcon;
				SqlCmd.CommandText = "Proc_Remover_Ponto";
				SqlCmd.CommandType = CommandType.StoredProcedure;

				SqlParameter ParID_Ponto = new SqlParameter();
				ParID_Ponto.ParameterName = "@ID";
				ParID_Ponto.SqlDbType = SqlDbType.Int;
				ParID_Ponto.Value = ID;
				SqlCmd.Parameters.Add(ParID_Ponto);


				Resp = SqlCmd.ExecuteNonQuery() == 1 ? "OK" : "Ponto Não Encontrado";



			}
			catch (Exception error)
			{

				Resp = error.Message;
			}

			finally { if (Sqlcon.State == ConnectionState.Open) Sqlcon.Close(); }
			return Resp;
		}

		///  
		public string Alterar_Ponto(PontoDTO ponto)
		{
			string Resp;

			SqlConnection Sqlcon = new SqlConnection();

			try
			{
				Sqlcon.ConnectionString = ConexaoDB.cn;
				Sqlcon.Open();
				SqlCommand SqlCmd = new SqlCommand();
				SqlCmd.Connection = Sqlcon;
				SqlCmd.CommandText = "Proc_Alterar_Ponto";
				SqlCmd.CommandType = CommandType.StoredProcedure;

				SqlParameter ParID_Ponto = new SqlParameter();
				ParID_Ponto.ParameterName = "@ID";
				ParID_Ponto.SqlDbType = SqlDbType.Int;
				ParID_Ponto.Value = ID;
				SqlCmd.Parameters.Add(ParID_Ponto);

				SqlParameter ParTipo_Ponto = new SqlParameter();
				ParTipo_Ponto.ParameterName = "@Tipo";
				ParTipo_Ponto.SqlDbType = SqlDbType.VarChar;
				ParTipo_Ponto.Size = 50;
				ParTipo_Ponto.Value = Tipo;
				SqlCmd.Parameters.Add(ParTipo_Ponto);

				SqlParameter ParID_Parada = new SqlParameter();
				ParID_Parada.ParameterName = "@ID";
				ParID_Parada.SqlDbType = SqlDbType.Int;
				ParID_Parada.Value = ID_Parada;
				SqlCmd.Parameters.Add(ParID_Parada);


				Resp = SqlCmd.ExecuteNonQuery() == 1 ? "OK" : "Edicao Não Concluida";



			}
			catch (Exception error)
			{

				Resp = error.Message;
			}

			finally { if (Sqlcon.State == ConnectionState.Open) Sqlcon.Close(); }
			return Resp;

		}

		///  
		public DataTable Buscar_Ponto(PontoDTO ponto)
		{
			DataTable DtResultado = new DataTable("Ponto");

			SqlConnection Sqlcon = new SqlConnection();

			try
			{
				Sqlcon.ConnectionString = ConexaoDB.cn;
				SqlCommand SqlCmd = new SqlCommand();
				SqlCmd.Connection = Sqlcon;
				SqlCmd.CommandText = "Proc_Buscar_Ponto";
				SqlCmd.CommandType = CommandType.StoredProcedure;


				SqlParameter Partextobuscar = new SqlParameter();
				Partextobuscar.ParameterName = "@textobuscar";
				Partextobuscar.SqlDbType = SqlDbType.VarChar;
				Partextobuscar.Size = 50;
				Partextobuscar.Value = txtBuscar;
				SqlCmd.Parameters.Add(Partextobuscar);

				SqlDataAdapter SqlDat = new SqlDataAdapter(SqlCmd);
				SqlDat.Fill(DtResultado);


			}
			catch (Exception error)
			{
				DtResultado = null;

			}

			finally { if (Sqlcon.State == ConnectionState.Open) Sqlcon.Close(); }

			return DtResultado;


		}

	}

}