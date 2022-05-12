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

namespace BusSpot.Cadastro
{
	public class Reclamacao_Business
	{

        public static string Inserir(string nome, string email, string telefone, string descricao, dateTime data_rec, string retorno)
        {

            ReclamacaoDTO obj = new();
            obj.nome = nome;
          


            return obj.Incluir_Bairro(obj);

        }

        public static string Editar(int id, string nome)
        {

            BairroDTO obj = new();
            obj.ID = id;
            obj.nome = nome;


            return obj.Alterar_Bairro(obj);

        }

        public static DataTable Buscar(string nome)
        {

            BairroDTO obj = new();
            obj.txtBuscar = nome;

            return obj.Buscar_Bairro(obj);

        }

        public static string Remover(int id)
        {

            BairroDTO obj = new();
            obj.ID = id;

            return obj.Remover_Bairro(obj);

        }

        public static DataTable Mostrar()
        {
            return new BairroDTO().Mostrar_Bairro();


        }

    }
}

