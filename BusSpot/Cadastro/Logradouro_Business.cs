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
    public class Logradouro_Business
    {
        public static string Inserir(string nome)
        {

            LogradouroDTO obj = new();
            obj.nome = nome;


            return obj.Incluir_Logradouro(obj);

        }

        public static string Editar(int id, string nome)
        {

            LogradouroDTO obj = new();
            obj.ID = id;
            obj.nome = nome;


            return obj.Alterar_Logradouro(obj);

        }

        public static DataTable Buscar(string nome)
        {

            LogradouroDTO obj = new();
            obj.txtBuscar = nome;

            return obj.Buscar_Logradouro(obj);

        }

        public static string Remover(int id)
        {

            LogradouroDTO obj = new();
            obj.ID = id;

            return obj.Remover_Logradouro(obj);

        }

        public static DataTable Mostrar()
        {
            return new LogradouroDTO().Mostrar_Logradouro();


        }
    }
}
