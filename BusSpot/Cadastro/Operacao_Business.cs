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
using BusSpot.Transporte;
using Classes.Transporte;


namespace BusSpot.Cadastro
{
    public class Operacao_Business
    {
        public static string Inserir(DateTime dataop, int id_onibus, int id_linha)
        {

            OperacaoDTO obj = new();
            obj.Data_Op = dataop;
            obj.ID_Onibus = id_onibus;
            obj.ID_Linha = id_linha;

            return obj.Incluir_Operacao(obj);

        }

        public static string Editar(int id, DateTime dataop, int id_onibus, int id_linha)
        {

            OperacaoDTO obj = new();
            obj.ID = id;
            obj.Data_Op = dataop;
            obj.ID_Onibus = id_onibus;
            obj.ID_Linha = id_linha;

            return obj.Alterar_Ponto(obj);

        }

        public static DataTable Buscar(string nome)
        {

            OperacaoDTO obj = new();
            obj.txtBuscar = nome;

            return obj.Buscar_Operação(obj);

        }

        public static string Remover(int id)
        {

            OperacaoDTO obj = new();
            obj.ID = id;

            return obj.Remover_Operacao(obj);

        }

        public static DataTable Mostrar()
        {
            return new OperacaoDTO().Mostrar_Operacao();


        }
    }
}
