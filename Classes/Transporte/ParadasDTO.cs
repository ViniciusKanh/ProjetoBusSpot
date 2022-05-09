using System.Data;
using System.Data.SqlTypes;
using System.Data.SqlClient;

namespace Classes.Transporte
{
	public class ParadasDTO
	{
		public int ID { get; set; }
		public String Latitude { get;  set; }

		public String Longitude { get;  set; }

		public String Nome { get;  set; }

		public int ID_ENDERECO { get;  set; }

		public String txtBuscar { get; set; }



		public ParadasDTO()
        {
        }



        ///  
        public string Incluir_Parada(ParadasDTO parada)
		{
			string Resp;

			SqlConnection Sqlcon = new SqlConnection();

			try
			{
				Sqlcon.ConnectionString = ConexaoDB.cn;
				Sqlcon.Open();
				SqlCommand SqlCmd = new SqlCommand();
				SqlCmd.Connection = Sqlcon;
				SqlCmd.CommandText = "Proc_Inserir_Parada";
				SqlCmd.CommandType = CommandType.StoredProcedure;

				SqlParameter ParLatitude_Parada = new SqlParameter();
				ParLatitude_Parada.ParameterName = "@Latitude";
				ParLatitude_Parada.SqlDbType = SqlDbType.VarChar;
				ParLatitude_Parada.Size = 50;
				ParLatitude_Parada.Value = Latitude;
				SqlCmd.Parameters.Add(ParLatitude_Parada);

				SqlParameter ParLongitude_Parada = new SqlParameter();
				ParLongitude_Parada.ParameterName = "@Longitude";
				ParLongitude_Parada.SqlDbType = SqlDbType.VarChar;
				ParLongitude_Parada.Size = 50;
				ParLongitude_Parada.Value = Longitude;
				SqlCmd.Parameters.Add(ParLongitude_Parada);

				SqlParameter ParNome_Parada = new SqlParameter();
				ParNome_Parada.ParameterName = "@NOME";
				ParNome_Parada.SqlDbType = SqlDbType.VarChar;
				ParNome_Parada.Size = 50;
				ParNome_Parada.Value = Nome;
				SqlCmd.Parameters.Add(ParNome_Parada);

				SqlParameter ParID_Endereco = new SqlParameter();
				ParID_Endereco.ParameterName = "@ID_ENDERECO";
				ParID_Endereco.SqlDbType = SqlDbType.Int;
				ParID_Endereco.Value = ID_ENDERECO;
				SqlCmd.Parameters.Add(ParID_Endereco);

				Resp = SqlCmd.ExecuteNonQuery() == 1 ? "OK" : "Parada Não Inserido";



			}
			catch (Exception error)
			{

				Resp = error.Message;
			}

			finally { if (Sqlcon.State == ConnectionState.Open) Sqlcon.Close(); }

			return Resp;

		}

		public DataTable Mostrar_Parada()
		{
			DataTable DtResultado = new DataTable("Parada");

			SqlConnection Sqlcon = new SqlConnection();

			try
			{
				Sqlcon.ConnectionString = ConexaoDB.cn;
				SqlCommand SqlCmd = new SqlCommand();
				SqlCmd.Connection = Sqlcon;
				SqlCmd.CommandText = "Proc_Mostrar_Parada";
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
		public string Remover__Parada(ParadasDTO parada)
		{

			string Resp;

			SqlConnection Sqlcon = new SqlConnection();

			try
			{
				Sqlcon.ConnectionString = ConexaoDB.cn;
				Sqlcon.Open();
				SqlCommand SqlCmd = new SqlCommand();
				SqlCmd.Connection = Sqlcon;
				SqlCmd.CommandText = "Proc_Remover_Parada";
				SqlCmd.CommandType = CommandType.StoredProcedure;

				SqlParameter ParID_Parada = new SqlParameter();
				ParID_Parada.ParameterName = "@ID";
				ParID_Parada.SqlDbType = SqlDbType.Int;
				ParID_Parada.Value = ID;
				SqlCmd.Parameters.Add(ParID_Parada);


				Resp = SqlCmd.ExecuteNonQuery() == 1 ? "OK" : "Parada Não Encontrado";



			}
			catch (Exception error)
			{

				Resp = error.Message;
			}

			finally { if (Sqlcon.State == ConnectionState.Open) Sqlcon.Close(); }
			return Resp;

		}

		///  
		public string Alterar__Parada(ParadasDTO parada)
		{
			string Resp;

			SqlConnection Sqlcon = new SqlConnection();

			try
			{
				Sqlcon.ConnectionString = ConexaoDB.cn;
				Sqlcon.Open();
				SqlCommand SqlCmd = new SqlCommand();
				SqlCmd.Connection = Sqlcon;
				SqlCmd.CommandText = "Proc_Alterar_Parada";
				SqlCmd.CommandType = CommandType.StoredProcedure;

				SqlParameter ParID_Parada = new SqlParameter();
				ParID_Parada.ParameterName = "@ID";
				ParID_Parada.SqlDbType = SqlDbType.Int;
				ParID_Parada.Value = ID;
				SqlCmd.Parameters.Add(ParID_Parada);

				SqlParameter ParLatitude_Parada = new SqlParameter();
				ParLatitude_Parada.ParameterName = "@Latitude";
				ParLatitude_Parada.SqlDbType = SqlDbType.VarChar;
				ParLatitude_Parada.Size = 50;
				ParLatitude_Parada.Value = Latitude;
				SqlCmd.Parameters.Add(ParLatitude_Parada);

				SqlParameter ParLongitude_Parada = new SqlParameter();
				ParLongitude_Parada.ParameterName = "@Longitude";
				ParLongitude_Parada.SqlDbType = SqlDbType.VarChar;
				ParLongitude_Parada.Size = 50;
				ParLongitude_Parada.Value = Longitude;
				SqlCmd.Parameters.Add(ParLongitude_Parada);

				SqlParameter ParNome_Parada = new SqlParameter();
				ParNome_Parada.ParameterName = "@NOME";
				ParNome_Parada.SqlDbType = SqlDbType.VarChar;
				ParNome_Parada.Size = 50;
				ParNome_Parada.Value = Longitude;
				SqlCmd.Parameters.Add(ParNome_Parada);

				SqlParameter ParID_Endereco = new SqlParameter();
				ParID_Endereco.ParameterName = "@ID_ENDERECO";
				ParID_Endereco.SqlDbType = SqlDbType.Int;
				ParID_Endereco.Value = ID_ENDERECO;
				SqlCmd.Parameters.Add(ParID_Endereco);


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
		public DataTable Buscar_Parada(ParadasDTO parada)
		{
			DataTable DtResultado = new DataTable("Parada");

			SqlConnection Sqlcon = new SqlConnection();

			try
			{
				Sqlcon.ConnectionString = ConexaoDB.cn;
				SqlCommand SqlCmd = new SqlCommand();
				SqlCmd.Connection = Sqlcon;
				SqlCmd.CommandText = "Proc_Buscar_Parada";
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

		///  

	}

}