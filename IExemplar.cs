using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Livraria
{
	public interface IExemplar
	{
		public string GetNome();
		public double GetPreco();
		public void ExibirDados();
	}
}
