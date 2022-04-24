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
    public class Logradouro_Classes
    {
        public static string Inserir(string nome)
        {

            Logradouro obj = new();
            obj.nome = nome;


            return obj.Incluir_Logradouro(obj);

        }

        public static string Editar(int id, string nome)
        {

            Logradouro obj = new();
            obj.ID = id;
            obj.nome = nome;


            return obj.Alterar_Logradouro(obj);

        }

        public static DataTable Buscar(string nome)
        {

            Logradouro obj = new();
            obj.txtBuscar = nome;

            return obj.Buscar_Logradouro(obj);

        }

        public static string Remover(int id)
        {

            Logradouro obj = new();
            obj.ID = id;

            return obj.Remover_Logradouro(obj);

        }

        public static DataTable Mostrar()
        {
            return new Logradouro().Mostrar_Logradouro();


        }
    }
}
