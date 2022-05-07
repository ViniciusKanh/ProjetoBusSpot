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

	public class Ponto
	{
		public String Tipo { get; private set; }

		public Paradas paradas { get; private set; }

		public ColetivoDTO onibus { get; private set; }

		public Linhas linhas { get; private set; }

		public Paradas Paradas { get; private set; }

		public Ponto()
        {
        }

        public void Incluir_Ponto()
		{

		}

		///  
		public void Remover_Ponto()
		{

		}

		///  
		public void Alterar_Ponto()
		{

		}

		///  
		public void Buscar_Ponto()
		{

		}

	}

}