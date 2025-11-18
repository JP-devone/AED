using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Questao01
{
    internal class Celula
    {
        private string item;
        private Celula proximo;
        public string Item
        {
            get { return item; }
            set { item = value; }
        }
        public Celula Proximo
        {
            get { return proximo; }
            set { proximo = value; }
        }

        public Celula(string novoItem)
        {
            item = novoItem;
            proximo = null;
        }
        public Celula()
        {
            this.item = null;
            this.proximo = null;
        }
    }
}
