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
	public class Linhas
	{
		public String NumeroLinha { get; private set; }

		public String Descrição { get; private set; }

		public String HorarioPartida { get; private set; }

		public String HorarioChegada { get; private set; }

		public ColetivoDTO onibus { get; private set; }

		public Ponto ponto { get; private set; }

		public ICollection<Paradas> paradas { get; private set; }

		public EmpresaDTO empresa { get; private set; }

		public Linhas()
        {
        }





        ///  
        public void Incluir_Linha()
		{

		}

		///  
		public void Remover_Linha()
		{

		}

		///  
		public void Alterar_Linha()
		{

		}

		///  
		public void Buscar_Linha()
		{

		}

		///  
		public void Registro_VIagem()
		{

		}

		///  
		public void Horario_Pico()
		{

		}

	}

}