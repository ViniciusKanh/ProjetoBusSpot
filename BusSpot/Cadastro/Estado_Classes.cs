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


namespace BusSpot
{
    public class Estado_Classes
    {
        public static string Inserir(string nome, string sigla)
        {

            Estado obj = new();
            obj.nome = nome;
            obj.sigla = sigla;

            return obj.Incluir_Estado(obj);
       
        }

        public static string Editar(int id, string nome, string sigla)
        {

            Estado obj = new();
            obj.ID = id;
            obj.nome = nome;
            obj.sigla = sigla;

            return obj.Alterar_Estado(obj);

        }

        public static DataTable Buscar(string sigla)
        {

            Estado obj = new();
            obj.txtBuscar = sigla;

            return obj.Buscar_Estado(obj);

        }

        public static string Remover(int id)
        {

            Estado obj = new();
            obj.ID= id;

            return obj.Remover_Estado(obj);

        }

        public static DataTable Mostrar()
        {
            return new Estado().Mostrar_Estado();
           

        }
    }
}
