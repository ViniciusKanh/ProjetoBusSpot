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
    public class Coletivo_Business
    {
        public static string Inserir(string numero, string placa, int id_comodidade, int id_pagamento, int id_acessibilidade, int id_embarque, int id_empresa)
        {

            ColetivoDTO obj = new();
            obj.N_Onibus = numero;
            obj.Placa = placa;
            obj.ID_Comodidade = id_comodidade;
            obj.ID_Pagamento = id_pagamento;
            obj.ID_Acessibilidade = id_acessibilidade;
            obj.ID_Embarque = id_embarque;
            obj.ID_Empresa = id_empresa;

            return obj.Incluir_Onibus(obj);

        }

        public static string Editar(int id, string numero, string placa, int id_comodidade, int id_pagamento, int id_acessibilidade, int id_embarque, int id_empresa)
        {

            ColetivoDTO obj = new();
            obj.ID = id;
            obj.N_Onibus = numero;
            obj.Placa = placa;
            obj.ID_Comodidade = id_comodidade;
            obj.ID_Pagamento = id_pagamento;
            obj.ID_Acessibilidade = id_acessibilidade;
            obj.ID_Embarque = id_embarque;
            obj.ID_Empresa = id_empresa;

            return obj.Alterar_Onibus(obj);

        }

        public static DataTable Buscar(string nome)
        {

            ColetivoDTO obj = new();
            obj.txtBuscar = nome;

            return obj.Buscar_Onibus(obj);

        }

        public static string Remover(int id)
        {

            ColetivoDTO obj = new();
            obj.ID = id;

            return obj.Remover_Onibus(obj);

        }

        public static DataTable Mostrar()
        {
            return new ColetivoDTO().Mostrar_Onibus();


        }
    }
}
