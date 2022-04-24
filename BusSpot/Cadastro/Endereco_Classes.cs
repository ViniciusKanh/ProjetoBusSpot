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
    public class Endereco_Classes
    {
        public static string Inserir(string cep, int idbairro, int idcidade,int idlogradouro, int idtipologradouro)
        {

            Endereco obj = new();
            obj.cep = cep;
            obj.IDBairro = idbairro;
            obj.IDCidade = idcidade;
            obj.IDLogradouro = idlogradouro;
            obj.IDTipoLogradouro = idtipologradouro;

            return obj.Incluir_cep(obj);

        }

        public static string Editar(int id, string cep, int idbairro, int idcidade, int idlogradouro, int idtipologradouro)
        {

            Endereco obj = new();
            obj.ID = id;
            obj.cep = cep;
            obj.IDBairro = idbairro;
            obj.IDCidade = idcidade;
            obj.IDLogradouro = idlogradouro;
            obj.IDTipoLogradouro = idtipologradouro;

            return obj.Alterar_cep(obj);

        }

        public static DataTable Buscar(string cep)
        {

            Endereco obj = new();
            obj.txtBuscar = cep;

            return obj.Buscar_ViaCEP(obj);

        }

        public static string Remover(int id)
        {

            Endereco obj = new();
            obj.ID = id;

            return obj.Remover_cep(obj);

        }

        public static DataTable Mostrar()
        {
            return new Endereco().Mostrar_Endereco();


        }
    }
}
