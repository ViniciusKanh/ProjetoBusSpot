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
	public class Paradas
	{
		public String Latitude { get; private set; }

		public String Longitude { get; private set; }

		public String Nome { get; private set; }

		public Ponto ponto { get; private set; }

		public EmpresaDTO empresa { get; private set; }

		public Endereco.EnderecoDTO endereço { get; private set; }

		public ICollection<Linhas> linhas { get; private set; }

		public Ponto Ponto { get; private set; }

		public Paradas()
        {
        }



        ///  
        public void Incluir_Parada()
		{

		}

		///  
		public void Remover__Parada()
		{

		}

		///  
		public void Alterar__Parada()
		{

		}

		///  
		public void Buscar_Parada()
		{

		}

		///  
		public void Verifica_Coordenadas()
		{

		}

	}

}