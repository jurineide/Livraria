using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Livraria
{
	public class Editora
	{
		//Definir os atributos - características
		public string Nome {get; set;}
		
		private string site;
		public string Site { get; set; }

		private string telefone;
		public string Telefone { get; set; }

		public void ExibirDados()
		{
			Console.WriteLine("Editora: " + Nome);
		}
	}
}
