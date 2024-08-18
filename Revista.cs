using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Livraria
{
	public class Revista : IExemplar
	{
		public string Nome { get; set; }
		public string Descricao { get; set; }
		public double Preco { get; set; }
		public Editora Editora { get; set; }

		void IExemplar.ExibirDados()
		{
			Console.WriteLine("Revista: " + Nome);
		}

		string IExemplar.GetNome()
		{
			return Nome;
		}

		double IExemplar.GetPreco()
		{
			return Preco;
		}

	}
}
