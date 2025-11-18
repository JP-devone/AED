using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Questão04
{
    class Biblioteca
    {
        private Livro[] livros;
        private int numLivros;
        private const int MAXLIV = 50;

        public int NumLivros
        {
            get { return numLivros; }
            set { numLivros = value; }
        }
        public Biblioteca()
        {
            NumLivros = 0;
            livros = new Livro[MAXLIV];
        }
        public void AdicionarLivro(string titulo,string autores,string editora)
        {
            Livro livro = new Livro(titulo,autores,editora);
            livros[NumLivros] = livro;
            numLivros++;
        }
        public void AdicionarLivro(Livro livro)
        {
            livros[numLivros] = livro;
            numLivros++;
        }
        public Livro RetornaLivro(string titulo)
        {
            for(int i = 0; i < numLivros; i++)
            {
                if (titulo.Equals(livros[i].Titulo))
                {
                    return livros[i];
                }
            }
            return null;
        }
        public void ExibirListaDeLivros()
        {
            for(int i = 0;i < numLivros;i++)
            {
                Console.WriteLine(livros[i].Titulo);
            }
        }
        public void NumeroDeLivros()
        {
            Console.WriteLine(numLivros);
        }


    }
}
