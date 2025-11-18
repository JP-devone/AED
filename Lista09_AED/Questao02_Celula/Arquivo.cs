using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Questao02_Celula
{
    internal class Arquivo
    {
        private string nome;
        private int num_paginas;

        public string Nome
        {
            get { return nome; }
            set {  nome = value; }
        }
        public int Num_paginas
        {
            get { return num_paginas; }
            set { num_paginas = value; }
        }
        public Arquivo(string nome, int numero)
        {
            this.nome = nome;
            this.num_paginas = numero;  
        }
    }
}
