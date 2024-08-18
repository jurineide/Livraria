using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Livraria
{
	public class LivroDigital : Livro
	{
        public string MarcaDagua { get; set; }

		public LivroDigital(string nome, double valor) : base(nome, valor) { }

		public LivroDigital() { }

    }
}
