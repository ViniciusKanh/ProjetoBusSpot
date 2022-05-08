using System.Data;
using System.Data.SqlTypes;
using System.Data.SqlClient;

namespace Classes.Transporte
{
	public class LinhasDTO
	{
		public int ID { get; set; }

		public int ID_Empresa { get; set; }

		public int ID_Ponto { get; set; }	

		public String NumeroLinha { get;  set; }

		public String Descrição { get;  set; }

		public String txtBuscar { get; set; }


		public LinhasDTO()
        {
        }





        ///  
        public string Incluir_Linha(LinhasDTO linha)
		{

			string Resp;

			SqlConnection Sqlcon = new SqlConnection();

			try
			{
				Sqlcon.ConnectionString = ConexaoDB.cn;
				Sqlcon.Open();
				SqlCommand SqlCmd = new SqlCommand();
				SqlCmd.Connection = Sqlcon;
				SqlCmd.CommandText = "Proc_Inserir_Linha";
				SqlCmd.CommandType = CommandType.StoredProcedure;

				SqlParameter ParNumeroLinha_Linha = new SqlParameter();
				ParNumeroLinha_Linha.ParameterName = "@Numero_Linha";
				ParNumeroLinha_Linha.SqlDbType = SqlDbType.VarChar;
				ParNumeroLinha_Linha.Size = 50;
				ParNumeroLinha_Linha.Value = NumeroLinha;
				SqlCmd.Parameters.Add(ParNumeroLinha_Linha);

				SqlParameter ParDescricao_Linha = new SqlParameter();
				ParDescricao_Linha.ParameterName = "@Descricao_Linha";
				ParDescricao_Linha.SqlDbType = SqlDbType.VarChar;
				ParDescricao_Linha.Size = 50;
				ParDescricao_Linha.Value = Descrição;
				SqlCmd.Parameters.Add(ParDescricao_Linha);

				SqlParameter ParID_Empresa = new SqlParameter();
				ParID_Empresa.ParameterName = "@ID_EMPRESA";
				ParID_Empresa.SqlDbType = SqlDbType.Int;
				ParID_Empresa.Value = ID_Empresa;
				SqlCmd.Parameters.Add(ParID_Empresa);

				SqlParameter ParID_Ponto = new SqlParameter();
				ParID_Ponto.ParameterName = "@ID_PONTO";
				ParID_Ponto.SqlDbType = SqlDbType.Int;
				ParID_Ponto.Value = ID_Ponto;
				SqlCmd.Parameters.Add(ParID_Ponto);

				Resp = SqlCmd.ExecuteNonQuery() == 1 ? "OK" : "Linha Não Inserido";



			}
			catch (Exception error)
			{

				Resp = error.Message;
			}

			finally { if (Sqlcon.State == ConnectionState.Open) Sqlcon.Close(); }

			return Resp;

		}

		public DataTable Mostrar_Linha()
		{
			DataTable DtResultado = new DataTable("Linha");

			SqlConnection Sqlcon = new SqlConnection();

			try
			{
				Sqlcon.ConnectionString = ConexaoDB.cn;
				SqlCommand SqlCmd = new SqlCommand();
				SqlCmd.Connection = Sqlcon;
				SqlCmd.CommandText = "Proc_Mostrar_Linha";
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
		public string Remover_Linha(LinhasDTO linha)
		{
			string Resp;

			SqlConnection Sqlcon = new SqlConnection();

			try
			{
				Sqlcon.ConnectionString = ConexaoDB.cn;
				Sqlcon.Open();
				SqlCommand SqlCmd = new SqlCommand();
				SqlCmd.Connection = Sqlcon;
				SqlCmd.CommandText = "Proc_Remover_Linha";
				SqlCmd.CommandType = CommandType.StoredProcedure;

				SqlParameter ParID_Linha = new SqlParameter();
				ParID_Linha.ParameterName = "@ID";
				ParID_Linha.SqlDbType = SqlDbType.Int;
				ParID_Linha.Value = ID;
				SqlCmd.Parameters.Add(ParID_Linha);


				Resp = SqlCmd.ExecuteNonQuery() == 1 ? "OK" : "Linha Não Encontrado";



			}
			catch (Exception error)
			{

				Resp = error.Message;
			}

			finally { if (Sqlcon.State == ConnectionState.Open) Sqlcon.Close(); }
			return Resp;
		}

		///  
		public string Alterar_Linha(LinhasDTO linha)
		{

			string Resp;

			SqlConnection Sqlcon = new SqlConnection();

			try
			{
				Sqlcon.ConnectionString = ConexaoDB.cn;
				Sqlcon.Open();
				SqlCommand SqlCmd = new SqlCommand();
				SqlCmd.Connection = Sqlcon;
				SqlCmd.CommandText = "Proc_Alterar_Linha";
				SqlCmd.CommandType = CommandType.StoredProcedure;

				SqlParameter ParID_Linha = new SqlParameter();
				ParID_Linha.ParameterName = "@ID";
				ParID_Linha.SqlDbType = SqlDbType.Int;
				ParID_Linha.Value = ID;
				SqlCmd.Parameters.Add(ParID_Linha);


				SqlParameter ParNumeroLinha_Linha = new SqlParameter();
				ParNumeroLinha_Linha.ParameterName = "@Numero_Linha";
				ParNumeroLinha_Linha.SqlDbType = SqlDbType.VarChar;
				ParNumeroLinha_Linha.Size = 50;
				ParNumeroLinha_Linha.Value = NumeroLinha;
				SqlCmd.Parameters.Add(ParNumeroLinha_Linha);

				SqlParameter ParDescricao_Linha = new SqlParameter();
				ParDescricao_Linha.ParameterName = "@Descricao_Linha";
				ParDescricao_Linha.SqlDbType = SqlDbType.VarChar;
				ParDescricao_Linha.Size = 50;
				ParDescricao_Linha.Value = Descrição;
				SqlCmd.Parameters.Add(ParDescricao_Linha);

				SqlParameter ParID_Empresa = new SqlParameter();
				ParID_Empresa.ParameterName = "@ID_EMPRESA";
				ParID_Empresa.SqlDbType = SqlDbType.Int;
				ParID_Empresa.Value = ID_Empresa;
				SqlCmd.Parameters.Add(ParID_Empresa);

				SqlParameter ParID_Ponto = new SqlParameter();
				ParID_Ponto.ParameterName = "@ID_PONTO";
				ParID_Ponto.SqlDbType = SqlDbType.Int;
				ParID_Ponto.Value = ID_Ponto;
				SqlCmd.Parameters.Add(ParID_Ponto);



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
		public DataTable Buscar_Linha(LinhasDTO linha)
		{

			DataTable DtResultado = new DataTable("Onibus");

			SqlConnection Sqlcon = new SqlConnection();

			try
			{
				Sqlcon.ConnectionString = ConexaoDB.cn;
				SqlCommand SqlCmd = new SqlCommand();
				SqlCmd.Connection = Sqlcon;
				SqlCmd.CommandText = "Proc_Buscar_Linha";
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