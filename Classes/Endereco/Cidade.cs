using System.Data;
using System.Data.SqlTypes;
using System.Data.SqlClient;


namespace Classes.Endereco
{
    public class Cidade
    {
		public int ID { get;  set; }
		public String nome { get;  set; }

		public String cep { get;  set; }

		public string txtBuscar { get; set; }

		public int estado { get;  set; }

		public ICollection<Endereco> endereço { get;  set; }

        public Cidade()
        {
        }



        ///  
        public string Incluir_Cidade(Cidade cidade)
		{
			string Resp;

			SqlConnection Sqlcon = new SqlConnection();

			try
			{
				Sqlcon.ConnectionString = ConexaoDB.cn;
				Sqlcon.Open();
				SqlCommand SqlCmd = new SqlCommand();
				SqlCmd.Connection = Sqlcon;
				SqlCmd.CommandText = "Proc_Inserir_Cidade";
				SqlCmd.CommandType = CommandType.StoredProcedure;

				SqlParameter ParNome_CIDADE = new SqlParameter();
				ParNome_CIDADE.ParameterName = "@Nome";
				ParNome_CIDADE.SqlDbType = SqlDbType.VarChar;
				ParNome_CIDADE.Size = 50;
				ParNome_CIDADE.Value = nome;
				SqlCmd.Parameters.Add(ParNome_CIDADE);

				SqlParameter ParID_ESTADO = new SqlParameter();
				ParID_ESTADO.ParameterName = "@IDESTADO";
				ParID_ESTADO.SqlDbType = SqlDbType.Int;
				ParID_ESTADO.Value = estado;
				SqlCmd.Parameters.Add(ParID_ESTADO);

				SqlParameter ParCEP_CIDADE = new SqlParameter();
				ParCEP_CIDADE.ParameterName = "@CEP";
				ParCEP_CIDADE.SqlDbType = SqlDbType.VarChar;
				ParCEP_CIDADE.Size = 50;
				ParCEP_CIDADE.Value = cep;
				SqlCmd.Parameters.Add(ParCEP_CIDADE);


				Resp = SqlCmd.ExecuteNonQuery() == 1 ? "OK" : "Cidade Não Inserido";



			}
			catch (Exception error)
			{

				Resp = error.Message;
			}

			finally { if (Sqlcon.State == ConnectionState.Open) Sqlcon.Close(); }

			return Resp;
		}

		public DataTable Mostrar_Cidade()
		{
			DataTable DtResultado = new DataTable("Cidade");

			SqlConnection Sqlcon = new SqlConnection();

			try
			{
				Sqlcon.ConnectionString = ConexaoDB.cn;
				SqlCommand SqlCmd = new SqlCommand();
				SqlCmd.Connection = Sqlcon;
				SqlCmd.CommandText = "Proc_Mostrar_Cidade";
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
		public string Remover_Cidade(Cidade cidade)
		{
			string Resp;

			SqlConnection Sqlcon = new SqlConnection();

			try
			{
				Sqlcon.ConnectionString = ConexaoDB.cn;
				Sqlcon.Open();
				SqlCommand SqlCmd = new SqlCommand();
				SqlCmd.Connection = Sqlcon;
				SqlCmd.CommandText = "Proc_Remover_Cidade";
				SqlCmd.CommandType = CommandType.StoredProcedure;

				SqlParameter ParID_CIDADE = new SqlParameter();
				ParID_CIDADE.ParameterName = "@ID";
				ParID_CIDADE.SqlDbType = SqlDbType.Int;
				ParID_CIDADE.Value = ID;
				SqlCmd.Parameters.Add(ParID_CIDADE);


				Resp = SqlCmd.ExecuteNonQuery() == 1 ? "OK" : "Cidade Não Encontrado";



			}
			catch (Exception error)
			{

				Resp = error.Message;
			}

			finally { if (Sqlcon.State == ConnectionState.Open) Sqlcon.Close(); }
			return Resp;
		}

		///  
		public string Alterar_Cidade(Cidade cidade)
		{
			string Resp;

			SqlConnection Sqlcon = new SqlConnection();

			try
			{
				Sqlcon.ConnectionString = ConexaoDB.cn;
				Sqlcon.Open();
				SqlCommand SqlCmd = new SqlCommand();
				SqlCmd.Connection = Sqlcon;
				SqlCmd.CommandText = "Proc_Alterar_Cidade";
				SqlCmd.CommandType = CommandType.StoredProcedure;

				SqlParameter ParID_CIDADE = new SqlParameter();
				ParID_CIDADE.ParameterName = "@ID";
				ParID_CIDADE.SqlDbType = SqlDbType.Int;
				ParID_CIDADE.Value = ID;
				SqlCmd.Parameters.Add(ParID_CIDADE);


				SqlParameter ParNome_CIDADE = new SqlParameter();
				ParNome_CIDADE.ParameterName = "@Nome";
				ParNome_CIDADE.SqlDbType = SqlDbType.VarChar;
				ParNome_CIDADE.Size = 50;
				ParNome_CIDADE.Value = nome;
				SqlCmd.Parameters.Add(ParNome_CIDADE);

				SqlParameter ParID_ESTADO = new SqlParameter();
				ParID_ESTADO.ParameterName = "@IDESTADO";
				ParID_ESTADO.SqlDbType = SqlDbType.Int;
				ParID_ESTADO.Value = estado;
				SqlCmd.Parameters.Add(ParID_ESTADO);

				SqlParameter ParCEP_CIDADE = new SqlParameter();
				ParCEP_CIDADE.ParameterName = "@CEP";
				ParCEP_CIDADE.SqlDbType = SqlDbType.VarChar;
				ParCEP_CIDADE.Size = 50;
				ParCEP_CIDADE.Value = cep;
				SqlCmd.Parameters.Add(ParCEP_CIDADE);


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
		public DataTable Buscar_Cidade(Cidade cidade)
		{
			DataTable DtResultado = new DataTable("Cidade");

			SqlConnection Sqlcon = new SqlConnection();

			try
			{
				Sqlcon.ConnectionString = ConexaoDB.cn;
				SqlCommand SqlCmd = new SqlCommand();
				SqlCmd.Connection = Sqlcon;
				SqlCmd.CommandText = "[Proc_Buscar_Cidade]";
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
