using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;
using Classes.Endereco;
using Classes.Onibus;

namespace Classes.Transporte
{

	public class Empresa
	{
		public String Nome { get; private set; }

		public String CNPJ { get; private set; }

		public String Usuario { get; private set; }

		public String Senha { get; private set; }

		public String Numeral { get; private set; }

		public Coletivo onibus { get; private set; }

		public Paradas paradas { get; private set; }

		public Endereco.Endereco endereço { get; private set; }

		public Linhas linhas { get; private set; }

		public ICollection<Reclamacao> reclamacao { get; private set; }

		public Linhas Linhas { get; private set; }

		public Empresa(
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