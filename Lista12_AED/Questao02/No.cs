using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Questao02
{
    internal class No
    {
        private int item;
        private No direita;
        private No esquerda;
        public int Item
        {
            get { return item; }
            set { item = value; }
        }
        public No Direita
        {
            get { return direita; }
            set { direita = value; }
        }
        public No Esquerda
        {
            get { return esquerda; }
            set { esquerda = value; }
        }
        public No()
        {
            this.item = 0;
            this.direita = null;
            this.esquerda = null;
        }
        public No(int item)
        {
            this.item = item;
            this.direita = null;
            this.esquerda = null;
        }

    }
}
