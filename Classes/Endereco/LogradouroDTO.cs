using System.Data;
using System.Data.SqlTypes;
using System.Data.SqlClient;


namespace Classes.Endereco
{
	public class LogradouroDTO
	{
		public int ID { get; set; }
		public String nome { get; set; }
		public string txtBuscar { get; set; }

		public ICollection<EnderecoDTO> endereço { get; set; }

		public LogradouroDTO()
		{
		}

		///  
		public string Incluir_Logradouro(LogradouroDTO logradouro)
		{
			string Resp;

			SqlConnection Sqlcon = new SqlConnection();

			try
			{
				Sqlcon.ConnectionString = ConexaoDB.cn;
				Sqlcon.Open();
				SqlCommand SqlCmd = new SqlCommand();
				SqlCmd.Connection = Sqlcon;
				SqlCmd.CommandText = "Proc_Inserir_Logradouro";
				SqlCmd.CommandType = CommandType.StoredProcedure;

				SqlParameter ParNome_LOGRADOURO = new SqlParameter();
				ParNome_LOGRADOURO.ParameterName = "@Nome";
				ParNome_LOGRADOURO.SqlDbType = SqlDbType.VarChar;
				ParNome_LOGRADOURO.Size = 50;
				ParNome_LOGRADOURO.Value = nome;
				SqlCmd.Parameters.Add(ParNome_LOGRADOURO);

				Resp = SqlCmd.ExecuteNonQuery() == 1 ? "OK" : "Logradouro Não Inserido";



			}
			catch (Exception error)
			{

				Resp = error.Message;
			}

			finally { if (Sqlcon.State == ConnectionState.Open) Sqlcon.Close(); }

			return Resp;
		}


		public DataTable Mostrar_Logradouro()
		{
			DataTable DtResultado = new DataTable("Logradouro");

			SqlConnection Sqlcon = new SqlConnection();

			try
			{
				Sqlcon.ConnectionString = ConexaoDB.cn;
				SqlCommand SqlCmd = new SqlCommand();
				SqlCmd.Connection = Sqlcon;
				SqlCmd.CommandText = "Proc_Mostrar_Logradouro";
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
		public string Alterar_Logradouro(LogradouroDTO logradouro)
		{
			string Resp;

			SqlConnection Sqlcon = new SqlConnection();

			try
			{
				Sqlcon.ConnectionString = ConexaoDB.cn;
				Sqlcon.Open();
				SqlCommand SqlCmd = new SqlCommand();
				SqlCmd.Connection = Sqlcon;
				SqlCmd.CommandText = "Proc_Alterar_Logradouro";
				SqlCmd.CommandType = CommandType.StoredProcedure;

				SqlParameter ParID_LOGRADOURO = new SqlParameter();
				ParID_LOGRADOURO.ParameterName = "@ID";
				ParID_LOGRADOURO.SqlDbType = SqlDbType.Int;
				ParID_LOGRADOURO.Value = ID;
				SqlCmd.Parameters.Add(ParID_LOGRADOURO);


				SqlParameter ParNome_LOGRADOURO = new SqlParameter();
				ParNome_LOGRADOURO.ParameterName = "@Nome";
				ParNome_LOGRADOURO.SqlDbType = SqlDbType.VarChar;
				ParNome_LOGRADOURO.Size = 50;
				ParNome_LOGRADOURO.Value = nome;
				SqlCmd.Parameters.Add(ParNome_LOGRADOURO);


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
		public string Remover_Logradouro(LogradouroDTO logradouro)
		{
			string Resp;

			SqlConnection Sqlcon = new SqlConnection();

			try
			{
				Sqlcon.ConnectionString = ConexaoDB.cn;
				Sqlcon.Open();
				SqlCommand SqlCmd = new SqlCommand();
				SqlCmd.Connection = Sqlcon;
				SqlCmd.CommandText = "Proc_Remover_Logradouro";
				SqlCmd.CommandType = CommandType.StoredProcedure;

				SqlParameter ParID_LOGRADOURO = new SqlParameter();
				ParID_LOGRADOURO.ParameterName = "@ID";
				ParID_LOGRADOURO.SqlDbType = SqlDbType.Int;
				ParID_LOGRADOURO.Value = ID;
				SqlCmd.Parameters.Add(ParID_LOGRADOURO);


				Resp = SqlCmd.ExecuteNonQuery() == 1 ? "OK" : "Logradouro Não Encontrado";



			}
			catch (Exception error)
			{

				Resp = error.Message;
			}

			finally { if (Sqlcon.State == ConnectionState.Open) Sqlcon.Close(); }
			return Resp;
		}

		///  
		public DataTable Buscar_Logradouro(LogradouroDTO logradouro)
		{

			DataTable DtResultado = new DataTable("Logradouro");

			SqlConnection Sqlcon = new SqlConnection();

			try
			{
				Sqlcon.ConnectionString = ConexaoDB.cn;
				SqlCommand SqlCmd = new SqlCommand();
				SqlCmd.Connection = Sqlcon;
				SqlCmd.CommandText = "Proc_Buscar_Logradouro";
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

