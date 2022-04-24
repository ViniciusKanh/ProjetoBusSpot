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
    public class TipoLogradouro_Classes
    {
        public static string Inserir(string nome)
        {

            TipoLogradouro obj = new();
            obj.nome = nome;


            return obj.Incluir_TipoLogradouro(obj);

        }

        public static string Editar(int id, string nome)
        {

            TipoLogradouro obj = new();
            obj.ID = id;
            obj.nome = nome;


            return obj.Alterar_TipoLogradouro(obj);

        }

        public static DataTable Buscar(string nome)
        {

            TipoLogradouro obj = new();
            obj.txtBuscar = nome;

            return obj.Buscar_TipoLogradouro(obj);

        }

        public static string Remover(int id)
        {

            TipoLogradouro obj = new();
            obj.ID = id;

            return obj.Remover_TipoLogradouro(obj);

        }

        public static DataTable Mostrar()
        {
            return new TipoLogradouro().Mostrar_TipoLogradouro();


        }
    }
}
