using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Questao02_Celula
{
    internal class Celula
    {
        private Arquivo item;
        private Celula proximo;
        public Arquivo Item
        {
            get { return item; }
            set { item = value; }
        }
        public Celula Proximo
        {
            get { return proximo; }
            set { proximo = value; }
        }

        public Celula(Arquivo novoItem)
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
