using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;
using Classes.Endereco;
using Classes.Transporte;

namespace Classes.Onibus
{

	public class Coletivo
	{
		public String N_Onibus { get; private set; }

		public EmpresaDTO empresa { get; private set; }

		public Ponto ponto { get; private set; }

		public Comodidades comodidades { get; private set; }

		public Acessibilidade acessibilidade { get; private set; }

		public Embarque embarque { get; private set; }

		public Pagamento pagamento { get; private set; }

		public EmpresaDTO Empresa { get; private set; }

		public Comodidades Comodidades { get; private set; }

		public Acessibilidade Acessibilidade { get; private set; }

		public Embarque Embarque { get; private set; }

		public Pagamento Pagamento { get; private set; }

		public Linhas linhas { get; private set; }

		public Localizacao localizacao { get; private set; }

		public ICollection<Linhas> Linhas { get; private set; }

		public Coletivo()
        {
        }



        ///  
        public void Incluir_Onibus()
		{

		}

		///  
		public void Remover_Onibus()
		{

		}

		///  
		public void Alterar_Onibus()
		{

		}

		///  
		public void Buscar_Onibus()
		{

		}

		///  
		public void Quantidade_Onibus()
		{

		}

	}

}

