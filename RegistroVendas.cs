using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Livraria
{
	public class RegistroVendas
	{
		public double Total {  get; set; }
		/*
		public void Adicionar(Livro livro) //polimorfismo
		{
			Console.WriteLine("Livro adicionado " + livro.Nome);
			Total = Total + livro.Valor;
			
		}*/

		public void Adicionar(IExemplar item) //polimorfismo
		{
			Console.WriteLine("Produto adicionado " + item.GetNome());
			Total = Total + item.GetPreco();
		}

		
	}
}
