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
	public class Endereco 
{
	public String cep { get; private set; }

		public Bairro bairro { get; private set; }

		public TipoLogradouro tipoLogradouro { get; private set; }

		internal Cidade Cidade { get => Cidade; set => Cidade = value; }

		public Logradouro? logradouro { get; private set; }

		public ICollection<Empresa> empresa { get; private set; }

		public ICollection<Paradas> paradas { get; private set; }
     

     public Endereco()
        {
        }


        ///  
     public void Incluir_cep()
	{

	}

	///  
	public void Remover_cep()
	{

	}

	///  
	public void Alterar_cep()
	{

	}

	///  
	public void Buscar_ViaCEP()
	{

	}

	}
}

