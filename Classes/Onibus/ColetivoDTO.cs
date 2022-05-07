using System.Data;
using System.Data.SqlTypes;
using System.Data.SqlClient;

namespace Classes.Onibus
{

	public class ColetivoDTO
	{
		public int ID { get; set; }

		public int ID_Comodidade { get; set; }

		public int ID_Acessibilidade { get; set; }

		public int ID_Embarque { get; set; }

		public int ID_Pagamento { get; set; }

		public int ID_Empresa { get; set; }

		public String N_Onibus { get;  set; }
		
		public String Placa { get;  set; }

		public String txtBuscar { get; set; }

		public ColetivoDTO()
        {
        }



        ///  
        public string Incluir_Onibus(ColetivoDTO coletivo)
		{

			string Resp;

			SqlConnection Sqlcon = new SqlConnection();

			try
			{
				Sqlcon.ConnectionString = ConexaoDB.cn;
				Sqlcon.Open();
				SqlCommand SqlCmd = new SqlCommand();
				SqlCmd.Connection = Sqlcon;
				SqlCmd.CommandText = "Proc_Inserir_Onibus";
				SqlCmd.CommandType = CommandType.StoredProcedure;

				SqlParameter ParNumeroOnibus_Onibus = new SqlParameter();
				ParNumeroOnibus_Onibus.ParameterName = "@Numero_Onibus";
				ParNumeroOnibus_Onibus.SqlDbType = SqlDbType.VarChar;
				ParNumeroOnibus_Onibus.Size = 50;
				ParNumeroOnibus_Onibus.Value = N_Onibus;
				SqlCmd.Parameters.Add(ParNumeroOnibus_Onibus);

				SqlParameter ParPlaca_Onibus = new SqlParameter();
				ParPlaca_Onibus.ParameterName = "@Placa";
				ParPlaca_Onibus.SqlDbType = SqlDbType.VarChar;
				ParPlaca_Onibus.Size = 50;
				ParPlaca_Onibus.Value = Placa;
				SqlCmd.Parameters.Add(ParPlaca_Onibus);

				SqlParameter ParIDComodidade_Onibus = new SqlParameter();
				ParIDComodidade_Onibus.ParameterName = "@ID_Comodidade";
				ParIDComodidade_Onibus.SqlDbType = SqlDbType.Int;
				ParIDComodidade_Onibus.Value = ID_Acessibilidade;
				SqlCmd.Parameters.Add(ParIDComodidade_Onibus);

				SqlParameter ParIDPAGAMENTO_Onibus = new SqlParameter();
				ParIDPAGAMENTO_Onibus.ParameterName = "@ID_Pagamento";
				ParIDPAGAMENTO_Onibus.SqlDbType = SqlDbType.VarChar;
				ParIDPAGAMENTO_Onibus.Size = 50;
				ParIDPAGAMENTO_Onibus.Value = ID_Pagamento;
				SqlCmd.Parameters.Add(ParIDPAGAMENTO_Onibus);


				SqlParameter ParAcessibilidade_Onibus = new SqlParameter();
				ParAcessibilidade_Onibus.ParameterName = "@ID_Acessibilidade";
				ParAcessibilidade_Onibus.SqlDbType = SqlDbType.VarChar;
				ParAcessibilidade_Onibus.Size = 50;
				ParAcessibilidade_Onibus.Value = ID_Acessibilidade;
				SqlCmd.Parameters.Add(ParAcessibilidade_Onibus);


				SqlParameter ParIdEmbarque_Onibus = new SqlParameter();
				ParIdEmbarque_Onibus.ParameterName = "@ID_Embarque";
				ParIdEmbarque_Onibus.SqlDbType = SqlDbType.VarChar;
				ParIdEmbarque_Onibus.Size = 50;
				ParIdEmbarque_Onibus.Value = ID_Embarque;
				SqlCmd.Parameters.Add(ParIdEmbarque_Onibus);


				SqlParameter ParIdEmpresa_Onibus = new SqlParameter();
				ParIdEmpresa_Onibus.ParameterName = "@ID_Empresa";
				ParIdEmpresa_Onibus.SqlDbType = SqlDbType.VarChar;
				ParIdEmpresa_Onibus.Size = 50;
				ParIdEmpresa_Onibus.Value = ID_Empresa;
				SqlCmd.Parameters.Add(ParIdEmpresa_Onibus);

				Resp = SqlCmd.ExecuteNonQuery() == 1 ? "OK" : "Onibus Não Inserido";



			}
			catch (Exception error)
			{

				Resp = error.Message;
			}

			finally { if (Sqlcon.State == ConnectionState.Open) Sqlcon.Close(); }

			return Resp;

		}

		public DataTable Mostrar_Onibus()
		{
			DataTable DtResultado = new DataTable("Onibus");

			SqlConnection Sqlcon = new SqlConnection();

			try
			{
				Sqlcon.ConnectionString = ConexaoDB.cn;
				SqlCommand SqlCmd = new SqlCommand();
				SqlCmd.Connection = Sqlcon;
				SqlCmd.CommandText = "Proc_Mostrar_Onibus";
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
		public string Remover_Onibus(ColetivoDTO coletivo)
		{
			string Resp;

			SqlConnection Sqlcon = new SqlConnection();

			try
			{
				Sqlcon.ConnectionString = ConexaoDB.cn;
				Sqlcon.Open();
				SqlCommand SqlCmd = new SqlCommand();
				SqlCmd.Connection = Sqlcon;
				SqlCmd.CommandText = "Proc_Remover_Onibus";
				SqlCmd.CommandType = CommandType.StoredProcedure;

				SqlParameter ParID_Onibus = new SqlParameter();
				ParID_Onibus.ParameterName = "@ID";
				ParID_Onibus.SqlDbType = SqlDbType.Int;
				ParID_Onibus.Value = ID;
				SqlCmd.Parameters.Add(ParID_Onibus);


				Resp = SqlCmd.ExecuteNonQuery() == 1 ? "OK" : "Onibus Não Encontrado";



			}
			catch (Exception error)
			{

				Resp = error.Message;
			}

			finally { if (Sqlcon.State == ConnectionState.Open) Sqlcon.Close(); }
			return Resp;
		}

		///  
		public string Alterar_Onibus(ColetivoDTO coletivo)
		{
			string Resp;

			SqlConnection Sqlcon = new SqlConnection();

			try
			{
				Sqlcon.ConnectionString = ConexaoDB.cn;
				Sqlcon.Open();
				SqlCommand SqlCmd = new SqlCommand();
				SqlCmd.Connection = Sqlcon;
				SqlCmd.CommandText = "Proc_Alterar_Onibus";
				SqlCmd.CommandType = CommandType.StoredProcedure;

				SqlParameter ParID_Onibus = new SqlParameter();
				ParID_Onibus.ParameterName = "@ID";
				ParID_Onibus.SqlDbType = SqlDbType.Int;
				ParID_Onibus.Value = ID;
				SqlCmd.Parameters.Add(ParID_Onibus);


				SqlParameter ParNumeroOnibus_Onibus = new SqlParameter();
				ParNumeroOnibus_Onibus.ParameterName = "@Numero_Onibus";
				ParNumeroOnibus_Onibus.SqlDbType = SqlDbType.VarChar;
				ParNumeroOnibus_Onibus.Size = 50;
				ParNumeroOnibus_Onibus.Value = N_Onibus;
				SqlCmd.Parameters.Add(ParNumeroOnibus_Onibus);

				SqlParameter ParPlaca_Onibus = new SqlParameter();
				ParPlaca_Onibus.ParameterName = "@Placa";
				ParPlaca_Onibus.SqlDbType = SqlDbType.VarChar;
				ParPlaca_Onibus.Size = 50;
				ParPlaca_Onibus.Value = Placa;
				SqlCmd.Parameters.Add(ParPlaca_Onibus);

				SqlParameter ParIDComodidade_Onibus = new SqlParameter();
				ParIDComodidade_Onibus.ParameterName = "@ID_Comodidade";
				ParIDComodidade_Onibus.SqlDbType = SqlDbType.Int;
				ParIDComodidade_Onibus.Value = ID_Acessibilidade;
				SqlCmd.Parameters.Add(ParIDComodidade_Onibus);

				SqlParameter ParIDPAGAMENTO_Onibus = new SqlParameter();
				ParIDPAGAMENTO_Onibus.ParameterName = "@ID_Pagamento";
				ParIDPAGAMENTO_Onibus.SqlDbType = SqlDbType.VarChar;
				ParIDPAGAMENTO_Onibus.Size = 50;
				ParIDPAGAMENTO_Onibus.Value = ID_Pagamento;
				SqlCmd.Parameters.Add(ParIDPAGAMENTO_Onibus);


				SqlParameter ParAcessibilidade_Onibus = new SqlParameter();
				ParAcessibilidade_Onibus.ParameterName = "@ID_Acessibilidade";
				ParAcessibilidade_Onibus.SqlDbType = SqlDbType.VarChar;
				ParAcessibilidade_Onibus.Size = 50;
				ParAcessibilidade_Onibus.Value = ID_Acessibilidade;
				SqlCmd.Parameters.Add(ParAcessibilidade_Onibus);


				SqlParameter ParIdEmbarque_Onibus = new SqlParameter();
				ParIdEmbarque_Onibus.ParameterName = "@ID_Embarque";
				ParIdEmbarque_Onibus.SqlDbType = SqlDbType.VarChar;
				ParIdEmbarque_Onibus.Size = 50;
				ParIdEmbarque_Onibus.Value = ID_Embarque;
				SqlCmd.Parameters.Add(ParIdEmbarque_Onibus);


				SqlParameter ParIdEmpresa_Onibus = new SqlParameter();
				ParIdEmpresa_Onibus.ParameterName = "@@ID_Empresa";
				ParIdEmpresa_Onibus.SqlDbType = SqlDbType.VarChar;
				ParIdEmpresa_Onibus.Size = 50;
				ParIdEmpresa_Onibus.Value = ID_Empresa;
				SqlCmd.Parameters.Add(ParIdEmpresa_Onibus);



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
		public DataTable Buscar_Onibus(ColetivoDTO coletivo)
		{
			DataTable DtResultado = new DataTable("Onibus");

			SqlConnection Sqlcon = new SqlConnection();

			try
			{
				Sqlcon.ConnectionString = ConexaoDB.cn;
				SqlCommand SqlCmd = new SqlCommand();
				SqlCmd.Connection = Sqlcon;
				SqlCmd.CommandText = "Proc_Buscar_Onibus";
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

