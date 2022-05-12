using System;
using System.Data;
using System.Data.SqlTypes;
using System.Data.SqlClient;


namespace Classes.Transporte
{
	public class ReclamacaoDTO
	{

			public int ID { get; set; }

			public string nome { get; set; }

			public string email { get; set; }

			public string telefone { get; set; }

			public string descricao { get; set; }

			public DateTime data_rec { get; set; }

			public string retorno { get; set; }

			public string txtBuscar { get; set; }
		
		public ReclamacaoDTO() { }

		public string Incluir_Reclamacao(ReclamacaoDTO reclamacao)
		{

			string Resp;

			SqlConnection Sqlcon = new SqlConnection();

			try
			{
				Sqlcon.ConnectionString = ConexaoDB.cn;
				Sqlcon.Open();
				SqlCommand SqlCmd = new SqlCommand();
				SqlCmd.Connection = Sqlcon;
				SqlCmd.CommandText = "Proc_Inserir_Reclamacao";
				SqlCmd.CommandType = CommandType.StoredProcedure;

				SqlParameter ParNome_Reclamacao = new SqlParameter();
				ParNome_Reclamacao.ParameterName = "@Nome";
				ParNome_Reclamacao.SqlDbType = SqlDbType.VarChar;
				ParNome_Reclamacao.Size = 50;
				ParNome_Reclamacao.Value = nome;
				SqlCmd.Parameters.Add(ParNome_Reclamacao);

				Resp = SqlCmd.ExecuteNonQuery() == 1 ? "OK" : "Reclamacao N�o Inserido";



			}
			catch (Exception error)
			{

				Resp = error.Message;
			}

			finally { if (Sqlcon.State == ConnectionState.Open) Sqlcon.Close(); }

			return Resp;
		}

		public DataTable Mostrar_Reclamacao()
		{
			DataTable DtResultado = new DataTable("Reclamacao");

			SqlConnection Sqlcon = new SqlConnection();

			try
			{
				Sqlcon.ConnectionString = ConexaoDB.cn;
				SqlCommand SqlCmd = new SqlCommand();
				SqlCmd.Connection = Sqlcon;
				SqlCmd.CommandText = "Proc_Mostrar_Reclamacao";
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
		public string Alterar_Bairro(ReclamacaoDTO reclamacao)
		{
			string Resp;

			SqlConnection Sqlcon = new SqlConnection();

			try
			{
				Sqlcon.ConnectionString = ConexaoDB.cn;
				Sqlcon.Open();
				SqlCommand SqlCmd = new SqlCommand();
				SqlCmd.Connection = Sqlcon;
				SqlCmd.CommandText = "Proc_Alterar_Reclamacao";
				SqlCmd.CommandType = CommandType.StoredProcedure;

				SqlParameter ParID_BAIRRO = new SqlParameter();
				ParID_BAIRRO.ParameterName = "@ID";
				ParID_BAIRRO.SqlDbType = SqlDbType.Int;
				ParID_BAIRRO.Value = ID;
				SqlCmd.Parameters.Add(ParID_BAIRRO);



				Resp = SqlCmd.ExecuteNonQuery() == 1 ? "OK" : "Edicao N�o Concluida";



			}
			catch (Exception error)
			{

				Resp = error.Message;
			}

			finally { if (Sqlcon.State == ConnectionState.Open) Sqlcon.Close(); }
			return Resp;
		}

		///  
		public string Remover_Reclamacao(ReclamacaoDTO reclamacao)
		{
			string Resp;

			SqlConnection Sqlcon = new SqlConnection();

			try
			{
				Sqlcon.ConnectionString = ConexaoDB.cn;
				Sqlcon.Open();
				SqlCommand SqlCmd = new SqlCommand();
				SqlCmd.Connection = Sqlcon;
				SqlCmd.CommandText = "Proc_Remover_Reclamacao";
				SqlCmd.CommandType = CommandType.StoredProcedure;

				SqlParameter ParID_Reclamacao = new SqlParameter();
				ParID_Reclamacao.ParameterName = "@ID";
				ParID_Reclamacao.SqlDbType = SqlDbType.Int;
				ParID_Reclamacao.Value = ID;
				SqlCmd.Parameters.Add(ParID_Reclamacao);


				Resp = SqlCmd.ExecuteNonQuery() == 1 ? "OK" : "Bairro N�o Encontrado";



			}
			catch (Exception error)
			{

				Resp = error.Message;
			}

			finally { if (Sqlcon.State == ConnectionState.Open) Sqlcon.Close(); }
			return Resp;
		}

		///  
		public DataTable Buscar_Reclamacao(ReclamacaoDTO reclamacao)
		{
			DataTable DtResultado = new DataTable("Reclamacao");

			SqlConnection Sqlcon = new SqlConnection();

			try
			{
				Sqlcon.ConnectionString = ConexaoDB.cn;
				SqlCommand SqlCmd = new SqlCommand();
				SqlCmd.Connection = Sqlcon;
				SqlCmd.CommandText = "Proc_Buscar_Reclamacao";
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


