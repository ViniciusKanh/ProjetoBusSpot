using System.Data;
using System.Data.SqlTypes;
using System.Data.SqlClient;

namespace Classes.Transporte
{
    public class OperacaoDTO
    {
        public int ID { get; set; }
        public DateTime Data_Op { get; set; }

        public int ID_Onibus { get; set; }

        public int ID_Linha { get; set; }

        public String txtBuscar { get; set; }

		public string Incluir_Operacao(OperacaoDTO operacao)
		{
			string Resp;

			SqlConnection Sqlcon = new SqlConnection();

			try
			{
				Sqlcon.ConnectionString = ConexaoDB.cn;
				Sqlcon.Open();
				SqlCommand SqlCmd = new SqlCommand();
				SqlCmd.Connection = Sqlcon;
				SqlCmd.CommandText = "Proc_Inserir_Operacao";
				SqlCmd.CommandType = CommandType.StoredProcedure;

				SqlParameter ParData_Operacao = new SqlParameter();
				ParData_Operacao.ParameterName = "@Data_Op";
				ParData_Operacao.SqlDbType = SqlDbType.DateTime;
				ParData_Operacao.Value = Data_Op;
				SqlCmd.Parameters.Add(ParData_Operacao);

				SqlParameter ParID_Onibus = new SqlParameter();
				ParID_Onibus.ParameterName = "@ID_ONIBUS";
				ParID_Onibus.SqlDbType = SqlDbType.Int;
				ParID_Onibus.Value = ID_Onibus;
				SqlCmd.Parameters.Add(ParID_Onibus);

				SqlParameter ParID_Linha = new SqlParameter();
				ParID_Linha.ParameterName = "@ID_Linha";
				ParID_Linha.SqlDbType = SqlDbType.Int;
				ParID_Linha.Value = ID_Linha;
				SqlCmd.Parameters.Add(ParID_Linha);

				Resp = SqlCmd.ExecuteNonQuery() == 1 ? "OK" : "Operação Não Inserida";



			}
			catch (Exception error)
			{

				Resp = error.Message;
			}

			finally { if (Sqlcon.State == ConnectionState.Open) Sqlcon.Close(); }

			return Resp;

		}

		public DataTable Mostrar_Operacao()
		{
			DataTable DtResultado = new DataTable("Operação");

			SqlConnection Sqlcon = new SqlConnection();

			try
			{
				Sqlcon.ConnectionString = ConexaoDB.cn;
				SqlCommand SqlCmd = new SqlCommand();
				SqlCmd.Connection = Sqlcon;
				SqlCmd.CommandText = "Proc_Mostrar_Operacao";
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
		public string Remover_Operacao(OperacaoDTO operacao)
		{
			string Resp;

			SqlConnection Sqlcon = new SqlConnection();

			try
			{
				Sqlcon.ConnectionString = ConexaoDB.cn;
				Sqlcon.Open();
				SqlCommand SqlCmd = new SqlCommand();
				SqlCmd.Connection = Sqlcon;
				SqlCmd.CommandText = "Proc_Remover_Operacao";
				SqlCmd.CommandType = CommandType.StoredProcedure;

				SqlParameter ParID_Operacao = new SqlParameter();
				ParID_Operacao.ParameterName = "@ID";
				ParID_Operacao.SqlDbType = SqlDbType.Int;
				ParID_Operacao.Value = ID;
				SqlCmd.Parameters.Add(ParID_Operacao);


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
		public string Alterar_Ponto(OperacaoDTO operacao)
		{
			string Resp;

			SqlConnection Sqlcon = new SqlConnection();

			try
			{
				Sqlcon.ConnectionString = ConexaoDB.cn;
				Sqlcon.Open();
				SqlCommand SqlCmd = new SqlCommand();
				SqlCmd.Connection = Sqlcon;
				SqlCmd.CommandText = "Proc_Alterar_Operacao";
				SqlCmd.CommandType = CommandType.StoredProcedure;

				SqlParameter ParID_Operacao = new SqlParameter();
				ParID_Operacao.ParameterName = "@ID";
				ParID_Operacao.SqlDbType = SqlDbType.Int;
				ParID_Operacao.Value = ID;
				SqlCmd.Parameters.Add(ParID_Operacao);

				SqlParameter ParData_Operacao = new SqlParameter();
				ParData_Operacao.ParameterName = "@Data_Op";
				ParData_Operacao.SqlDbType = SqlDbType.DateTime;
				ParData_Operacao.Value = Data_Op;
				SqlCmd.Parameters.Add(ParData_Operacao);

				SqlParameter ParID_Onibus = new SqlParameter();
				ParID_Onibus.ParameterName = "@ID_ONIBUS";
				ParID_Onibus.SqlDbType = SqlDbType.Int;
				ParID_Onibus.Value = ID_Onibus;
				SqlCmd.Parameters.Add(ParID_Onibus);

				SqlParameter ParID_Linha = new SqlParameter();
				ParID_Linha.ParameterName = "@ID_Linha";
				ParID_Linha.SqlDbType = SqlDbType.Int;
				ParID_Linha.Value = ID_Linha;
				SqlCmd.Parameters.Add(ParID_Linha);


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
		public DataTable Buscar_Operação(OperacaoDTO operacao)
		{
			DataTable DtResultado = new DataTable("Operação");

			SqlConnection Sqlcon = new SqlConnection();

			try
			{
				Sqlcon.ConnectionString = ConexaoDB.cn;
				SqlCommand SqlCmd = new SqlCommand();
				SqlCmd.Connection = Sqlcon;
				SqlCmd.CommandText = "Proc_Buscar_Operacao";
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
