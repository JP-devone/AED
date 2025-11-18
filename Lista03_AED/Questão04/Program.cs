using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Questão04
{
    class Program
    {
        static void Main(string[] args)
        {
            Livro livro1 = new Livro("1808", "Laurentino Gomes", "Planeta");
            Livro livro2 = new Livro("1822", "Laurentino Gomes", "Nova Fronteira");
            Livro livro3 = new Livro("1832", "Laurentino Gomes", "Globo Livros");
            Biblioteca biblioteca = new Biblioteca();
            biblioteca.AdicionarLivro(livro1);
            biblioteca.AdicionarLivro(livro2);
            biblioteca.AdicionarLivro(livro3);
            biblioteca.AdicionarLivro("Percy Jackson","Rick Riordan","Intrínseca");
            if (biblioteca.RetornaLivro("1808") != null)
            {
                Console.WriteLine("Titulo: " + biblioteca.RetornaLivro("1808").Titulo);
                Console.WriteLine("Autor: " + biblioteca.RetornaLivro("1808").Autores);
                Console.WriteLine("Editora: " + biblioteca.RetornaLivro("1808").Editora);
            }
            else
                Console.WriteLine("Este livro não existe na biblioteca.");
            if (biblioteca.RetornaLivro("Querido John") != null)
            {
                Console.WriteLine("Titulo: " + biblioteca.RetornaLivro("Querido John").Titulo);
                Console.WriteLine("Autor: " + biblioteca.RetornaLivro("Querido John").Autores);
                Console.WriteLine("Editora: " + biblioteca.RetornaLivro("Querido John").Editora);
            }
            else
                Console.WriteLine("Este livro não existe na biblioteca.");
            Console.WriteLine("RELAÇÃO DE TODOS OS LIVROS DA BIBLIOTECA");
            biblioteca.ExibirListaDeLivros();
            biblioteca.NumeroDeLivros();
            Console.ReadKey();
        }
    }
}
