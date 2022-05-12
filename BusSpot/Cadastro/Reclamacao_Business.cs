using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Classes.Endereco;
using Classes;
using BusSpot;
using System.Data;
using System.Data.SqlTypes;
using System.Data.SqlClient;
using BusSpot.Cadastro;
using Classes.Transporte;

namespace BusSpot.Cadastro
{
	public class Reclamacao_Business
	{

        public static string Inserir(string nome, string email, string telefone, string descricao, DateTime data_rec, string retorno, int id_empresa)
        {

            ReclamacaoDTO obj = new();
            obj.nome = nome;
            obj.email = email;
            obj.telefone = telefone;
            obj.descricao = descricao;
            obj.data_rec = data_rec;
            obj.retorno = retorno;
            obj.Id_EMPRESA = id_empresa;
          


            return obj.Incluir_Reclamacao(obj);

        }

        public static string Editar(int id, string nome, string email, string telefone, string descricao, DateTime data_rec, string retorno, int id_empresa)
        {

            ReclamacaoDTO obj = new();
            obj.ID = id;
            obj.nome = nome;
            obj.email = email;
            obj.telefone = telefone;
            obj.descricao = descricao;
            obj.data_rec = data_rec;
            obj.retorno = retorno;
            obj.Id_EMPRESA = id_empresa;



            return obj.Alterar_Reclamacao(obj);

        }

        public static DataTable Buscar(string nome)
        {

            ReclamacaoDTO obj = new();
            obj.txtBuscar = nome;

            return obj.Buscar_Reclamacao(obj);

        }

        public static string Remover(int id)
        {

            ReclamacaoDTO obj = new();
            obj.ID = id;

            return obj.Remover_Reclamacao(obj);

        }

        public static DataTable Mostrar()
        {
            return new ReclamacaoDTO().Mostrar_Reclamacao();


        }

    }
}

