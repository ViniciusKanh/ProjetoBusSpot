using System.Data;
using System.Data.SqlTypes;
using System.Data.SqlClient;



namespace Classes.Endereco
{
	public class BairroDTO
	{
		public int ID { get; set; }
		public String nome { get;  set; }
		public string txtBuscar { get; set; }

		public ICollection<EnderecoDTO> endereço { get; set; }

		public BairroDTO()
		{
		}

		///  
		public string Incluir_Bairro(BairroDTO bairro)
		{

			string Resp;

			SqlConnection Sqlcon = new SqlConnection();

			try
			{
				Sqlcon.ConnectionString = ConexaoDB.cn;
				Sqlcon.Open();
				SqlCommand SqlCmd = new SqlCommand();
				SqlCmd.Connection = Sqlcon;
				SqlCmd.CommandText = "Proc_Inserir_Bairro";
				SqlCmd.CommandType = CommandType.StoredProcedure;

				SqlParameter ParNome_BAIRRO = new SqlParameter();
				ParNome_BAIRRO.ParameterName = "@Nome";
				ParNome_BAIRRO.SqlDbType = SqlDbType.VarChar;
				ParNome_BAIRRO.Size = 50;
				ParNome_BAIRRO.Value = nome;
				SqlCmd.Parameters.Add(ParNome_BAIRRO);

				Resp = SqlCmd.ExecuteNonQuery() == 1 ? "OK" : "Bairro Não Inserido";



			}
			catch (Exception error)
			{

				Resp = error.Message;
			}

			finally { if (Sqlcon.State == ConnectionState.Open) Sqlcon.Close(); }

			return Resp;
		}

		public DataTable Mostrar_Bairro()
		{
			DataTable DtResultado = new DataTable("Bairro");

			SqlConnection Sqlcon = new SqlConnection();

			try
			{
				Sqlcon.ConnectionString = ConexaoDB.cn;
				SqlCommand SqlCmd = new SqlCommand();
				SqlCmd.Connection = Sqlcon;
				SqlCmd.CommandText = "Proc_Mostrar_Bairro";
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
		public string Alterar_Bairro(BairroDTO bairro)
		{
			string Resp;

			SqlConnection Sqlcon = new SqlConnection();

			try
			{
				Sqlcon.ConnectionString = ConexaoDB.cn;
				Sqlcon.Open();
				SqlCommand SqlCmd = new SqlCommand();
				SqlCmd.Connection = Sqlcon;
				SqlCmd.CommandText = "Proc_Alterar_Bairro";
				SqlCmd.CommandType = CommandType.StoredProcedure;

				SqlParameter ParID_BAIRRO = new SqlParameter();
				ParID_BAIRRO.ParameterName = "@ID";
				ParID_BAIRRO.SqlDbType = SqlDbType.Int;
				ParID_BAIRRO.Value = ID;
				SqlCmd.Parameters.Add(ParID_BAIRRO);


				SqlParameter ParNome_BAIRRO = new SqlParameter();
				ParNome_BAIRRO.ParameterName = "@Nome";
				ParNome_BAIRRO.SqlDbType = SqlDbType.VarChar;
				ParNome_BAIRRO.Size = 50;
				ParNome_BAIRRO.Value = nome;
				SqlCmd.Parameters.Add(ParNome_BAIRRO);


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
		public string Remover_Bairro(BairroDTO bairro)
		{
			string Resp;

			SqlConnection Sqlcon = new SqlConnection();

			try
			{
				Sqlcon.ConnectionString = ConexaoDB.cn;
				Sqlcon.Open();
				SqlCommand SqlCmd = new SqlCommand();
				SqlCmd.Connection = Sqlcon;
				SqlCmd.CommandText = "Proc_Remover_Bairro";
				SqlCmd.CommandType = CommandType.StoredProcedure;

				SqlParameter ParID_BAIRRO = new SqlParameter();
				ParID_BAIRRO.ParameterName = "@ID";
				ParID_BAIRRO.SqlDbType = SqlDbType.Int;
				ParID_BAIRRO.Value = ID;
				SqlCmd.Parameters.Add(ParID_BAIRRO);


				Resp = SqlCmd.ExecuteNonQuery() == 1 ? "OK" : "Bairro Não Encontrado";



			}
			catch (Exception error)
			{

				Resp = error.Message;
			}

			finally { if (Sqlcon.State == ConnectionState.Open) Sqlcon.Close(); }
			return Resp;
		}

		///  
		public DataTable Buscar_Bairro(BairroDTO bairro)
		{
			DataTable DtResultado = new DataTable("Bairro");

			SqlConnection Sqlcon = new SqlConnection();

			try
			{
				Sqlcon.ConnectionString = ConexaoDB.cn;
				SqlCommand SqlCmd = new SqlCommand();
				SqlCmd.Connection = Sqlcon;
				SqlCmd.CommandText = "Proc_Buscar_Bairro";
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