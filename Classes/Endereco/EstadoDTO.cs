﻿using System.Data;
using System.Data.SqlTypes;
using System.Data.SqlClient;



namespace Classes.Endereco
{
    public class EstadoDTO
    {
		public int ID { get; set; }

		public String nome { get; set; }

		public String sigla { get; set; }

		public string txtBuscar { get; set; }

		//public Cidade cidade { get; private set; }


		public EstadoDTO()
        {
      
        }

        public EstadoDTO(string nome, string sigla)
        {
            this.nome = nome;
            this.sigla = sigla;
        }


        ///  
        public string Incluir_Estado(EstadoDTO estado)
		{
			string Resp;

            SqlConnection Sqlcon = new SqlConnection();

            try
            {
				Sqlcon.ConnectionString = ConexaoDB.cn;
				Sqlcon.Open();
				SqlCommand SqlCmd = new	SqlCommand();
				SqlCmd.Connection = Sqlcon;
				SqlCmd.CommandText = "Proc_Inserir_ESTADO";
				SqlCmd.CommandType = CommandType.StoredProcedure;

				SqlParameter ParID_ESTADO = new SqlParameter();
				ParID_ESTADO.ParameterName = "@IDESTADO";
				ParID_ESTADO.SqlDbType = SqlDbType.Int;
				ParID_ESTADO.Direction = ParameterDirection.Output;
				SqlCmd.Parameters.Add(ParID_ESTADO);

				SqlParameter ParNome_ESTADO = new SqlParameter();
				ParNome_ESTADO.ParameterName = "@Nome";
				ParNome_ESTADO.SqlDbType = SqlDbType.VarChar;
				ParNome_ESTADO.Size = 50;
				ParNome_ESTADO.Value = estado.nome;
				SqlCmd.Parameters.Add(ParNome_ESTADO);

				SqlParameter ParSigla_ESTADO = new SqlParameter();
				ParSigla_ESTADO.ParameterName = "@Sigla";
				ParSigla_ESTADO.SqlDbType = SqlDbType.VarChar;
				ParSigla_ESTADO.Size = 2;
				ParSigla_ESTADO.Value = estado.sigla;
				SqlCmd.Parameters.Add(ParSigla_ESTADO);


				Resp = SqlCmd.ExecuteNonQuery() == 1 ? "OK" : "Estado Não Inserido";



			}
            catch (Exception error)
            {

				Resp = error.Message;
            }

            finally {if (Sqlcon.State == ConnectionState.Open) Sqlcon.Close(); }

			return Resp;
		}

		public string Alterar_Estado(EstadoDTO estado)
		{
			string Resp;

			SqlConnection Sqlcon = new SqlConnection();

			try
			{
				Sqlcon.ConnectionString = ConexaoDB.cn;
				Sqlcon.Open();
				SqlCommand SqlCmd = new SqlCommand();
				SqlCmd.Connection = Sqlcon;
				SqlCmd.CommandText = "Proc_Editar_ESTADO";
				SqlCmd.CommandType = CommandType.StoredProcedure;

				SqlParameter ParID_ESTADO = new SqlParameter();
				ParID_ESTADO.ParameterName = "@IDESTADO";
				ParID_ESTADO.SqlDbType = SqlDbType.Int;
				ParID_ESTADO.Value = estado.ID;
				SqlCmd.Parameters.Add(ParID_ESTADO);

				SqlParameter ParNome_ESTADO = new SqlParameter();
				ParNome_ESTADO.ParameterName = "@Nome";
				ParNome_ESTADO.SqlDbType = SqlDbType.VarChar;
				ParNome_ESTADO.Size = 50;
				ParNome_ESTADO.Value = estado.nome;
				SqlCmd.Parameters.Add(ParNome_ESTADO);

				SqlParameter ParSigla_ESTADO = new SqlParameter();
				ParSigla_ESTADO.ParameterName = "@Sigla";
				ParSigla_ESTADO.SqlDbType = SqlDbType.VarChar;
				ParSigla_ESTADO.Size = 2;
				ParSigla_ESTADO.Value = estado.sigla;
				SqlCmd.Parameters.Add(ParSigla_ESTADO);


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
		public string Remover_Estado(EstadoDTO estado)
		{
			string Resp;

			SqlConnection Sqlcon = new SqlConnection();

			try
			{
				Sqlcon.ConnectionString = ConexaoDB.cn;
				Sqlcon.Open();
				SqlCommand SqlCmd = new SqlCommand();
				SqlCmd.Connection = Sqlcon;
				SqlCmd.CommandText = "Proc_Remover_ESTADO";
				SqlCmd.CommandType = CommandType.StoredProcedure;

				SqlParameter ParID_ESTADO = new SqlParameter();
				ParID_ESTADO.ParameterName = "@IDESTADO";
				ParID_ESTADO.SqlDbType = SqlDbType.Int;
				ParID_ESTADO.Value = estado.ID;
				SqlCmd.Parameters.Add(ParID_ESTADO);


				Resp = SqlCmd.ExecuteNonQuery() == 1 ? "OK" : "Estado Não Encontrado";



			}
			catch (Exception error)
			{

				Resp = error.Message;
			}

			finally { if (Sqlcon.State == ConnectionState.Open) Sqlcon.Close(); }
			return Resp;
		}

		///  
		public DataTable Buscar_Estado(EstadoDTO estado)
		{
			DataTable DtResultado = new DataTable("Estado");

			SqlConnection Sqlcon = new SqlConnection();

			try
			{
				Sqlcon.ConnectionString = ConexaoDB.cn;
				SqlCommand SqlCmd = new SqlCommand();
				SqlCmd.Connection = Sqlcon;
				SqlCmd.CommandText = "Proc_Buscar_ESTADO";
				SqlCmd.CommandType = CommandType.StoredProcedure;
				

				SqlParameter Partextobuscar = new SqlParameter();
				Partextobuscar.ParameterName = "@textobuscar";
				Partextobuscar.SqlDbType = SqlDbType.VarChar;
				Partextobuscar.Size = 2;
				Partextobuscar.Value = estado.txtBuscar;
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

		public DataTable Mostrar_Estado()
        {
			DataTable DtResultado = new DataTable("Estado");

			SqlConnection Sqlcon = new SqlConnection();

			try
			{
				Sqlcon.ConnectionString = ConexaoDB.cn;
				SqlCommand SqlCmd = new SqlCommand();
				SqlCmd.Connection = Sqlcon;
				SqlCmd.CommandText = "Proc_Mostrar_ESTADO";
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
	}
}
