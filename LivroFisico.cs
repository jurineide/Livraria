using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Livraria
{
	public class LivroFisico : Livro
	{
		public LivroFisico(string nome, double valor) : base(nome, valor){ }
	
		//Método que calcula a taxa de impressão do livro
		public double GetTaxaImpressao()
		{
			return Valor * 0.05;
		}
	}

}
