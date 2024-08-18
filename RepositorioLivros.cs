using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Livraria
{
	public class RepositorioLivros
	{
		ArrayList nomes = new ArrayList();

		List<Livro> livros = new List<Livro>();
		HashSet<Livro> livroSemDuplicidade = new HashSet<Livro>();

		public RepositorioLivros()
		{
			LivroFisico lf = new LivroFisico("TesteLF", 30);
			livros.Add(lf);
			LivroFisico lf2 = new LivroFisico("TesteLF2", 30);
			livros.Add(lf2);
			LivroDigital ld = new LivroDigital("TesteLD", 25);
			livros.Add(ld);
			LivroDigital ld2 = new LivroDigital("TesteLD2", 25);
			livros.Add(ld2);
			LivroBolso lb = new LivroBolso("TesteLB", 15);
			livros.Add(lb);
			LivroBolso lb2 = new LivroBolso("TesteLB2", 15);
			livros.Add(lb2);
		}
		public void vetor()
		{
			//Vetor => Array => conjunto de informações de mesmo tipo
			//Definir o tamanho ao criar o vetor
			int[] x = { 1, 2, 3, 4, 5, 6 };
			Console.WriteLine(x[0]);
		}

		public void AddArrayList() {

			//Declaração de um ArrayList
			
			//Adicionar um item
		//	nomes.Add("1");
			nomes.Add("Eliane");
			nomes.Add("Ana");
			nomes.Add("Andre");

			nomes.Insert(2, "Joao"); //Insiro a informação em uma determinada posição
			Console.WriteLine(nomes.Contains("Eliane"));
			
			ExibirArrayList();
			nomes.RemoveAt(2);

			foreach(string nome in nomes)
			{
				Console.WriteLine(nome);
			}
			
		}

		public void ExibirArrayList()
		{
			Console.WriteLine("\nExibindo lista .....\n");
			for (int i = 0; i < nomes.Count; i++) {
				Console.WriteLine(nomes[i]);
			}

		}

		public void ExibirLista()
		{
			Console.WriteLine("\nExibindo lista .....\n");
			for (int i = 0; i < livros.Count; i++)
			{
				Console.WriteLine(livros[i].Nome);
			}
		}

		public void ExibirListaforeach()
		{
			Console.WriteLine("\nExibindo a lista com foreach");
			foreach (Livro l in livros)
			{
				Console.WriteLine($"Nome do livro: {l.Nome}");
			}

			Console.WriteLine("\nExibindo a lista com o método ForEach");
			livros.ForEach(i => Console.WriteLine("Nome do livro: " + i.Nome));

			Console.WriteLine("\nExibindo a lista com o método ForEach com mais de uma ação");
			livros.ForEach(i => {
				Console.WriteLine("Nome do livro: " + i.Nome);
				Console.WriteLine("Preço: R$ " + i.Valor);
			});

		}

		public void BuscarPorTitulo(string titulo)
		{
			var livro = livros.FirstOrDefault(e => titulo.Equals(e.Nome, StringComparison.OrdinalIgnoreCase));
			if (livro == null)
				Console.WriteLine("Livro não encontrado");
			else
			{
				Console.WriteLine("Livro está disponível");
				Console.WriteLine("Seu preço é: " + livro.Valor.ToString());
			}

			
		}

		public void BuscarPorTitulo2(string titulo)
		{
			
			if(livros.Any(e => titulo.Equals(e.Nome, StringComparison.OrdinalIgnoreCase)))
				Console.WriteLine("Livro está disponível");
			else
				Console.WriteLine("Livro não encontrado");
			
				
		}
	}
}
