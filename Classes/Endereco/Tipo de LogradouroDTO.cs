using System.Data;
using System.Data.SqlTypes;
using System.Data.SqlClient;

namespace Classes.Endereco
{
	public class TipoLogradouro
	{
		public int ID { get; set; }
		public String nome { get; set; }
		public string txtBuscar { get; set; }

		public EnderecoDTO endereço { get; private set; }

		public TipoLogradouro()
        {
        }


        ///  
        public string Incluir_TipoLogradouro(TipoLogradouro tipoLogradouro)
		{
			string Resp;

			SqlConnection Sqlcon = new SqlConnection();

			try
			{
				Sqlcon.ConnectionString = ConexaoDB.cn;
				Sqlcon.Open();
				SqlCommand SqlCmd = new SqlCommand();
				SqlCmd.Connection = Sqlcon;
				SqlCmd.CommandText = "Proc_Inserir_TipoLogradouro";
				SqlCmd.CommandType = CommandType.StoredProcedure;

				SqlParameter ParNome_TIPOLOGRADOURO = new SqlParameter();
				ParNome_TIPOLOGRADOURO.ParameterName = "@Nome";
				ParNome_TIPOLOGRADOURO.SqlDbType = SqlDbType.VarChar;
				ParNome_TIPOLOGRADOURO.Size = 50;
				ParNome_TIPOLOGRADOURO.Value = nome;
				SqlCmd.Parameters.Add(ParNome_TIPOLOGRADOURO);

				Resp = SqlCmd.ExecuteNonQuery() == 1 ? "OK" : "Tipo de Logradouro Não Inserido";



			}
			catch (Exception error)
			{

				Resp = error.Message;
			}

			finally { if (Sqlcon.State == ConnectionState.Open) Sqlcon.Close(); }

			return Resp;
		}

		public DataTable Mostrar_TipoLogradouro()
		{
			DataTable DtResultado = new DataTable("Tipo de Logradouro");

			SqlConnection Sqlcon = new SqlConnection();

			try
			{
				Sqlcon.ConnectionString = ConexaoDB.cn;
				SqlCommand SqlCmd = new SqlCommand();
				SqlCmd.Connection = Sqlcon;
				SqlCmd.CommandText = "Proc_Mostrar_TipoLogradouro";
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
		public string Remover_TipoLogradouro(TipoLogradouro tipoLogradouro)
		{
			string Resp;

			SqlConnection Sqlcon = new SqlConnection();

			try
			{
				Sqlcon.ConnectionString = ConexaoDB.cn;
				Sqlcon.Open();
				SqlCommand SqlCmd = new SqlCommand();
				SqlCmd.Connection = Sqlcon;
				SqlCmd.CommandText = "Proc_Remover_TipoLogradouro";
				SqlCmd.CommandType = CommandType.StoredProcedure;

				SqlParameter ParID_TIPOLOGRADOURO = new SqlParameter();
				ParID_TIPOLOGRADOURO.ParameterName = "@ID";
				ParID_TIPOLOGRADOURO.SqlDbType = SqlDbType.Int;
				ParID_TIPOLOGRADOURO.Value = ID;
				SqlCmd.Parameters.Add(ParID_TIPOLOGRADOURO);


				Resp = SqlCmd.ExecuteNonQuery() == 1 ? "OK" : "Tipo de Logradouro Não Encontrado";



			}
			catch (Exception error)
			{

				Resp = error.Message;
			}

			finally { if (Sqlcon.State == ConnectionState.Open) Sqlcon.Close(); }
			return Resp;
		}

		///  
		public string Alterar_TipoLogradouro(TipoLogradouro tipoLogradouro)
		{
			string Resp;

			SqlConnection Sqlcon = new SqlConnection();

			try
			{
				Sqlcon.ConnectionString = ConexaoDB.cn;
				Sqlcon.Open();
				SqlCommand SqlCmd = new SqlCommand();
				SqlCmd.Connection = Sqlcon;
				SqlCmd.CommandText = "Proc_Alterar_TipoLogradouro";
				SqlCmd.CommandType = CommandType.StoredProcedure;

				SqlParameter ParID_TIPOLOGRADOURO = new SqlParameter();
				ParID_TIPOLOGRADOURO.ParameterName = "@ID";
				ParID_TIPOLOGRADOURO.SqlDbType = SqlDbType.Int;
				ParID_TIPOLOGRADOURO.Value = ID;
				SqlCmd.Parameters.Add(ParID_TIPOLOGRADOURO);

				SqlParameter ParNome_TIPOLOGRADOURO = new SqlParameter();
				ParNome_TIPOLOGRADOURO.ParameterName = "@Nome";
				ParNome_TIPOLOGRADOURO.SqlDbType = SqlDbType.VarChar;
				ParNome_TIPOLOGRADOURO.Size = 50;
				ParNome_TIPOLOGRADOURO.Value = nome;
				SqlCmd.Parameters.Add(ParNome_TIPOLOGRADOURO);

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
		public DataTable Buscar_TipoLogradouro(TipoLogradouro tipoLogradouro)
		{
			DataTable DtResultado = new DataTable("Logradouro");

			SqlConnection Sqlcon = new SqlConnection();

			try
			{
				Sqlcon.ConnectionString = ConexaoDB.cn;
				SqlCommand SqlCmd = new SqlCommand();
				SqlCmd.Connection = Sqlcon;
				SqlCmd.CommandText = "Proc_Buscar_TipoLogradouro";
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

