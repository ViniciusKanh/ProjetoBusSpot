using System.Collections.Generic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;
using Classes.Endereco;
using Classes.Onibus;
using Classes.Transporte;


namespace Classes.Endereco
{
    public class Cidade
    {
		public String nome { get; private set; }

		public String cep { get; private set; }

		public Estado estado { get; private set; }

		public ICollection<Endereco> endereço { get; private set; }

        public Cidade()
        {
        }



        ///  
        public void Incluir_Cidade()
		{

		}

		///  
		public void Remover_Cidade()
		{

		}

		///  
		public void Alterar_Cidade()
		{

		}

		///  
		public void Buscar_Cidade()
		{

		}
	}
}
