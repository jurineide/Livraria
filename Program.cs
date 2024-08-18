// See https://aka.ms/new-console-template for more information
using Livraria;


//Instanciar um objeto do tipo Editora
Editora novaEditora = new Editora();
novaEditora.Nome = "Novatec";
novaEditora.Telefone = "1129875485";
novaEditora.Site = "www.novatec.com.br";

//Console.WriteLine("Editora: " + novaEditora.Nome);
//Instanciar um objeto -> Criar o objeto na memória
Livro meuLivro = new Livro("Harry Potter", novaEditora);
//Console.WriteLine(meuLivro.Nome);
meuLivro.Paginas = 150;
meuLivro.Valor = 100;
meuLivro.Resumo = "Harry Potter é um bruxo ...";
meuLivro.Autor = "Autor x";
//meuLivro.Nome = "Harry Potter";
meuLivro.SetIdioma("Ingles");
//meuLivro.Editora = novaEditora;
meuLivro.ExibirDados();
//Console.WriteLine(meuLivro.Nome + " foi publicado pela editora: " + meuLivro.Editora.Nome);

LivroFisico livroUML = new LivroFisico("UML2", 100);
//livroUML.Nome = "UML2";
livroUML.Autor = "Gilleanes Guedes";
livroUML.Paginas = 485;
livroUML.Resumo = "UML 2.0 uma abordagem prática";
livroUML.TipoCapa = ETipoCapa.Capa_Dura;
//livroUML.Idioma = "Portugues";
livroUML.ExibirDados();

LivroDigital livroDigital = new LivroDigital();
livroDigital.Nome = "Sem criatividade";

RegistroVendas carrinho = new RegistroVendas();
carrinho.Adicionar(livroUML);
carrinho.Adicionar(meuLivro);

Console.WriteLine(livroUML.TipoCapa);
Console.WriteLine((int)livroUML.TipoCapa);


Revista revista = new Revista();
revista.Nome = "SQL Magazine";
revista.Preco = 40.0;
revista.Descricao = "Revista especializada sobre Banco de Dados";
revista.Editora = novaEditora;
carrinho.Adicionar(revista);
Console.WriteLine("Total da compra R$ " + carrinho.Total);

Console.Clear();
RepositorioLivros repositorioLivros = new RepositorioLivros();
//repositorioLivros.AddArrayList();
//repositorioLivros.ExibirArrayList();

repositorioLivros.ExibirListaforeach();
repositorioLivros.BuscarPorTitulo("TesteLd");

