using System.Data;
using System.Data.SqlTypes;
using System.Data.SqlClient;


namespace Classes.Transporte
{

	public class EmpresaDTO
	{
		public int ID { get; set; }
		public String Fantasia { get; set; }

		public String CNPJ { get; set; }

		public int ID_Endereco { get; set; }

		public String Usuario { get; set; }

		public String Senha { get; set; }

		public String Numeral { get; set; }

		public EmpresaDTO(
			)
        {
        }



        ///  
        public string Incluir_Empresa(EmpresaDTO empresa)
		{
			string Resp;

			SqlConnection Sqlcon = new SqlConnection();

			try
			{
				Sqlcon.ConnectionString = ConexaoDB.cn;
				Sqlcon.Open();
				SqlCommand SqlCmd = new SqlCommand();
				SqlCmd.Connection = Sqlcon;
				SqlCmd.CommandText = "Proc_Inserir_Empresa";
				SqlCmd.CommandType = CommandType.StoredProcedure;

				SqlParameter ParFantasia_Empresa = new SqlParameter();
				ParFantasia_Empresa.ParameterName = "@Fantasia";
				ParFantasia_Empresa.SqlDbType = SqlDbType.VarChar;
				ParFantasia_Empresa.Size = 50;
				ParFantasia_Empresa.Value = Fantasia;
				SqlCmd.Parameters.Add(ParFantasia_Empresa);

				SqlParameter ParCNPJ_Empresa = new SqlParameter();
				ParCNPJ_Empresa.ParameterName = "@CNPJ";
				ParCNPJ_Empresa.SqlDbType = SqlDbType.VarChar;
				ParCNPJ_Empresa.Size = 50;
				ParCNPJ_Empresa.Value = CNPJ;
				SqlCmd.Parameters.Add(ParCNPJ_Empresa);

				SqlParameter ParID_Endereco = new SqlParameter();
				ParID_Endereco.ParameterName = "@ID_ENDERECO";
				ParID_Endereco.SqlDbType = SqlDbType.Int;
				ParID_Endereco.Value = ID_Endereco;
				SqlCmd.Parameters.Add(ParID_Endereco);

				SqlParameter ParUsuario_Empresa = new SqlParameter();
				ParUsuario_Empresa.ParameterName = "@Usuario";
				ParUsuario_Empresa.SqlDbType = SqlDbType.VarChar;
				ParUsuario_Empresa.Size = 50;
				ParUsuario_Empresa.Value = Usuario;
				SqlCmd.Parameters.Add(ParUsuario_Empresa);


				SqlParameter ParSenha_Empresa = new SqlParameter();
				ParSenha_Empresa.ParameterName = "@Senha";
				ParSenha_Empresa.SqlDbType = SqlDbType.VarChar;
				ParSenha_Empresa.Size = 50;
				ParSenha_Empresa.Value = Senha;
				SqlCmd.Parameters.Add(ParSenha_Empresa);


				SqlParameter ParNumeral_Empresa = new SqlParameter();
				ParNumeral_Empresa.ParameterName = "@NUMERAL";
				ParNumeral_Empresa.SqlDbType = SqlDbType.VarChar;
				ParNumeral_Empresa.Size = 50;
				ParNumeral_Empresa.Value = Numeral;
				SqlCmd.Parameters.Add(ParNumeral_Empresa);


				Resp = SqlCmd.ExecuteNonQuery() == 1 ? "OK" : "Cidade N�o Inserido";



			}
			catch (Exception error)
			{

				Resp = error.Message;
			}

			finally { if (Sqlcon.State == ConnectionState.Open) Sqlcon.Close(); }

			return Resp;
		}

		///  
		public void Remover_Empresa()
		{

		}

		///  
		public void Alterar_Empresa()
		{

		}

		///  
		public void Buscar_Empresa()
		{

		}

		public String Valida_CNPJ()
		{
			return null;
		}

		public String Valida_IE()
		{
			return null;
		}

	}

}