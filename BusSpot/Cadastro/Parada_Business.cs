using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Classes.Endereco;
using Classes.Transporte;
using Classes;
using BusSpot;
using System.Data;
using System.Data.SqlTypes;
using System.Data.SqlClient;
using BusSpot.Cadastro;
using BusSpot.Transporte;
using Classes.Onibus;

namespace BusSpot.Cadastro
{
    public class Parada_Business
    {
        public static string Inserir(string latitude, string longitude, string nome, int ID_endereco)
        {

            ParadasDTO obj = new();
            obj.Latitude = latitude;
            obj.Longitude = longitude;
            obj.Nome = nome;
            obj.ID_ENDERECO = ID_endereco;

            return obj.Incluir_Parada(obj);

        }

        public static string Editar(int id, string latitude, string longitude, string nome, int ID_endereco)
        {

            ParadasDTO obj = new();
            obj.ID = id;
            obj.Latitude = latitude;
            obj.Longitude = longitude;
            obj.Nome = nome;
            obj.ID_ENDERECO = ID_endereco;

            return obj.Alterar__Parada(obj);

        }

        public static DataTable Buscar(string nome)
        {

            ParadasDTO obj = new();
            obj.txtBuscar = nome;

            return obj.Buscar_Parada(obj);

        }

        public static string Remover(int id)
        {

            ParadasDTO obj = new();
            obj.ID = id;

            return obj.Remover__Parada(obj);

        }

        public static DataTable Mostrar()
        {
            return new ParadasDTO().Mostrar_Parada();


        }
    }
}
