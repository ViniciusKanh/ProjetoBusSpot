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
    public class Cidade_Business
    {
        public static string Inserir(string nome, int IDESTADO, string Cep)
        {

            CidadeDTO obj = new();
            obj.nome = nome;
            obj.estado = IDESTADO;
            obj.cep = Cep;

            return obj.Incluir_Cidade(obj);

        }

        public static string Editar(int id, string nome, int IDESTADO, string Cep)
        {

            CidadeDTO obj = new();
            obj.ID=id;
            obj.nome = nome;
            obj.estado = IDESTADO;
            obj.cep = Cep;

            return obj.Alterar_Cidade(obj);

        }

        public static DataTable Buscar(string nome)
        {

            CidadeDTO obj = new();
            obj.txtBuscar = nome;

            return obj.Buscar_Cidade(obj);

        }

        public static string Remover(int id)
        {

            CidadeDTO obj = new();
            obj.ID = id;

            return obj.Remover_Cidade(obj);

        }

        public static DataTable Mostrar()
        {
            return new CidadeDTO().Mostrar_Cidade();


        }
    }
}
