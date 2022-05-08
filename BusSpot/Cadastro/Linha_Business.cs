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
    public class Linha_Business
    {
        public static string Inserir(string numero_linha, string descricao_linha, int id_empresa, int id_ponto)
        {

            LinhasDTO obj = new();
            obj.NumeroLinha = numero_linha;
            obj.Descrição = descricao_linha;
            obj.ID_Empresa = id_empresa;
            obj.ID_Ponto = id_ponto;

            return obj.Incluir_Linha(obj);

        }

        public static string Editar(int id, string numero_linha, string descricao_linha, int id_empresa, int id_ponto)
        {

            LinhasDTO obj = new();
            obj.ID = id;
            obj.NumeroLinha = numero_linha;
            obj.Descrição = descricao_linha;
            obj.ID_Empresa = id_empresa;
            obj.ID_Ponto = id_ponto;

            return obj.Alterar_Linha(obj);

        }

        public static DataTable Buscar(string nome)
        {

            LinhasDTO obj = new();
            obj.txtBuscar = nome;

            return obj.Buscar_Linha(obj);

        }

        public static string Remover(int id)
        {

            LinhasDTO obj = new();
            obj.ID = id;

            return obj.Remover_Linha(obj);

        }

        public static DataTable Mostrar()
        {
            return new LinhasDTO().Mostrar_Linha();


        }
    }
}
