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

		public int Id_EMPRESA { get; set; }

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

				SqlParameter ParEmail_Reclamacao = new SqlParameter();
				ParEmail_Reclamacao.ParameterName = "@EMAIL";
				ParEmail_Reclamacao.SqlDbType = SqlDbType.VarChar;
				ParEmail_Reclamacao.Size = 50;
				ParEmail_Reclamacao.Value = email;
				SqlCmd.Parameters.Add(ParEmail_Reclamacao);

				SqlParameter ParTelefone_Reclamacao = new SqlParameter();
				ParTelefone_Reclamacao.ParameterName = "@TELEFONE";
				ParTelefone_Reclamacao.SqlDbType = SqlDbType.VarChar;
				ParTelefone_Reclamacao.Size = 11;
				ParTelefone_Reclamacao.Value = telefone;
				SqlCmd.Parameters.Add(ParTelefone_Reclamacao);

				SqlParameter ParDescricao_Reclamacao = new SqlParameter();
				ParDescricao_Reclamacao.ParameterName = "@DESCRICAO";
				ParDescricao_Reclamacao.SqlDbType = SqlDbType.VarChar;
				ParDescricao_Reclamacao.Size = 50;
				ParNome_Reclamacao.Value = descricao;
				SqlCmd.Parameters.Add(ParNome_Reclamacao);


				SqlParameter ParDataRec_Reclamacao = new SqlParameter();
				ParDataRec_Reclamacao.ParameterName = "@DATA_REC";
				ParDataRec_Reclamacao.SqlDbType = SqlDbType.Date;
				ParDataRec_Reclamacao.Value = data_rec;
				SqlCmd.Parameters.Add(ParDataRec_Reclamacao);

				SqlParameter ParRetorno_Reclamacao = new SqlParameter();
				ParRetorno_Reclamacao.ParameterName = "@RETORNO";
				ParRetorno_Reclamacao.SqlDbType = SqlDbType.VarChar;
				ParRetorno_Reclamacao.Size = 50;
				ParRetorno_Reclamacao.Value = retorno;
				SqlCmd.Parameters.Add(ParRetorno_Reclamacao);


				SqlParameter ParIDEMPRESA_Reclamacao = new SqlParameter();
				ParIDEMPRESA_Reclamacao.ParameterName = "@ID_EMPRESA";
				ParIDEMPRESA_Reclamacao.SqlDbType = SqlDbType.Int;
				ParIDEMPRESA_Reclamacao.Value = Id_EMPRESA;
				SqlCmd.Parameters.Add(ParIDEMPRESA_Reclamacao);

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
		public string Alterar_Reclamacao(ReclamacaoDTO reclamacao)
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

				SqlParameter ParID_Reclamacao = new SqlParameter();
				ParID_Reclamacao.ParameterName = "@ID";
				ParID_Reclamacao.SqlDbType = SqlDbType.Int;
				ParID_Reclamacao.Value = ID;
				SqlCmd.Parameters.Add(ParID_Reclamacao);

				SqlParameter ParNome_Reclamacao = new SqlParameter();
				ParNome_Reclamacao.ParameterName = "@Nome";
				ParNome_Reclamacao.SqlDbType = SqlDbType.VarChar;
				ParNome_Reclamacao.Size = 50;
				ParNome_Reclamacao.Value = nome;
				SqlCmd.Parameters.Add(ParNome_Reclamacao);

				SqlParameter ParEmail_Reclamacao = new SqlParameter();
				ParEmail_Reclamacao.ParameterName = "@EMAIL";
				ParEmail_Reclamacao.SqlDbType = SqlDbType.VarChar;
				ParEmail_Reclamacao.Size = 50;
				ParEmail_Reclamacao.Value = email;
				SqlCmd.Parameters.Add(ParEmail_Reclamacao);

				SqlParameter ParTelefone_Reclamacao = new SqlParameter();
				ParTelefone_Reclamacao.ParameterName = "@TELEFONE";
				ParTelefone_Reclamacao.SqlDbType = SqlDbType.VarChar;
				ParTelefone_Reclamacao.Size = 11;
				ParTelefone_Reclamacao.Value = telefone;
				SqlCmd.Parameters.Add(ParTelefone_Reclamacao);

				SqlParameter ParDescricao_Reclamacao = new SqlParameter();
				ParDescricao_Reclamacao.ParameterName = "@DESCRICAO";
				ParDescricao_Reclamacao.SqlDbType = SqlDbType.VarChar;
				ParDescricao_Reclamacao.Size = 50;
				ParNome_Reclamacao.Value = descricao;
				SqlCmd.Parameters.Add(ParNome_Reclamacao);


				SqlParameter ParDataRec_Reclamacao = new SqlParameter();
				ParDataRec_Reclamacao.ParameterName = "@DATA_REC";
				ParDataRec_Reclamacao.SqlDbType = SqlDbType.Date;
				ParDataRec_Reclamacao.Value = data_rec;
				SqlCmd.Parameters.Add(ParDataRec_Reclamacao);

				SqlParameter ParRetorno_Reclamacao = new SqlParameter();
				ParRetorno_Reclamacao.ParameterName = "@RETORNO";
				ParRetorno_Reclamacao.SqlDbType = SqlDbType.VarChar;
				ParRetorno_Reclamacao.Size = 50;
				ParRetorno_Reclamacao.Value = retorno;
				SqlCmd.Parameters.Add(ParRetorno_Reclamacao);


				SqlParameter ParIDEMPRESA_Reclamacao = new SqlParameter();
				ParIDEMPRESA_Reclamacao.ParameterName = "@ID_EMPRESA";
				ParIDEMPRESA_Reclamacao.SqlDbType = SqlDbType.Int;
				ParIDEMPRESA_Reclamacao.Value = Id_EMPRESA;
				SqlCmd.Parameters.Add(ParIDEMPRESA_Reclamacao);



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


