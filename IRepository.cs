using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Livraria
{
	public interface IRepository
	{
		void Save(IRepository repository);
		IRepository ListAll();
	}
}
