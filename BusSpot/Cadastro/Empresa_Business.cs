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

namespace BusSpot.Cadastro
{
    public class Empresa_Business
    {
        public static string Inserir(string fantasia, string cnpj, int id_endereco, string usuario, string senha, string numeral)
        {

            EmpresaDTO obj = new();
            obj.Fantasia = fantasia;
            obj.CNPJ = cnpj;
            obj.ID_Endereco = id_endereco;
            obj.Usuario = usuario;
            obj.Senha = senha;
            obj.Numeral = numeral;

            return obj.Incluir_Empresa(obj);

        }

        public static string Editar(int id, string fantasia, string cnpj, int id_endereco, string usuario, string senha, string numeral)
        {

            EmpresaDTO obj = new();
            obj.ID = id;
            obj.Fantasia = fantasia;
            obj.CNPJ = cnpj;
            obj.ID_Endereco = id_endereco;
            obj.Usuario = usuario;
            obj.Senha = senha;
            obj.Numeral = numeral;

            return obj.Alterar_Empresa(obj);

        }

        public static DataTable Buscar(string nome)
        {

            EmpresaDTO obj = new();
            obj.txtBuscar = nome;

            return obj.Buscar_Empresa(obj);

        }

        public static string Remover(int id)
        {

            EmpresaDTO obj = new();
            obj.ID = id;

            return obj.Remover_Empresa(obj);

        }

        public static DataTable Mostrar()
        {
            return new EmpresaDTO().Mostrar_Empresa();


        }
    }
}
