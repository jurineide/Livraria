using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Livraria
{
	public class DVD : IExemplar
	{

		public string NomeDVD {  get; set; }
		public double PrecoDVD {  get; set; }

		

		void IExemplar.ExibirDados()
		{
			Console.WriteLine("DVD especial");
		}

		string IExemplar.GetNome()
		{
			return NomeDVD;
		}

		double IExemplar.GetPreco()
		{
			return PrecoDVD;
		}
	}
}
