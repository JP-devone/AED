using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Questão04
{
    class Livro
    {
        private string titulo;
        private string autores;
        private string editora;

        public Livro(string titulo,string autores,string editora)
        {
            this.titulo = titulo;
            this.autores = autores;
            this.editora = editora;
        }

        public string Editora
        {
            get { return editora; }
            set { editora = value; }
        }


        public string Autores
        {
            get { return autores; }
            set { autores = value; }
        }


        public string Titulo
        {
            get { return titulo; }
            set { titulo = value; }
        }


    }
}
