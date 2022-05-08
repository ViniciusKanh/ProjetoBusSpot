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
    public class Ponto_Business
    {
        public static string Inserir(string tipo, int ID_Parada)
        {

            PontoDTO obj = new();
            obj.Tipo = tipo;
            obj.ID_Parada = ID_Parada;
           
            return obj.Incluir_Ponto(obj);

        }

        public static string Editar(int id, string tipo, int ID_Parada)
        {

            PontoDTO obj = new();
            obj.ID = id;
            obj.Tipo = tipo;
            obj.ID_Parada = ID_Parada;

            return obj.Alterar_Ponto(obj);

        }

        public static DataTable Buscar(string nome)
        {

            PontoDTO obj = new();
            obj.txtBuscar = nome;

            return obj.Buscar_Ponto(obj);

        }

        public static string Remover(int id)
        {

            PontoDTO obj = new();
            obj.ID = id;

            return obj.Remover_Ponto(obj);

        }

        public static DataTable Mostrar()
        {
            return new PontoDTO().Mostrar_Ponto();


        }
    }
}
