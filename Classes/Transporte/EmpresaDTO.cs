using System.Data;
using System.Data.SqlTypes;
using System.Data.SqlClient;


namespace Classes.Transporte
{

	public class EmpresaDTO
	{
		public String Nome { get; set; }

		public String CNPJ { get; set; }

		public String Usuario { get; set; }

		public String Senha { get; set; }

		public String Numeral { get; set; }

		public Coletivo onibus { get; set; }

		public Paradas paradas { get; set; }

		public EmpresaDTO(
			)
        {
        }



        ///  
        public void Incluir_Empresa()
		{

		}

		///  
		public void Remover_Empresa()
		{

		}

		///  
		public void Alterar_Empresa()
		{

		}

		///  
		public void Buscar_Empresa()
		{

		}

		public String Valida_CNPJ()
		{
			return null;
		}

		public String Valida_IE()
		{
			return null;
		}

	}

}