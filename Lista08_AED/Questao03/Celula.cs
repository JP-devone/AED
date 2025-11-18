using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Questao03
{
    internal class Celula
    {
        private Celula proximo;
        private int item;
        public Celula Proximo
        {
            get { return proximo; }
            set { proximo = value; }
        }
        public int Item
        {
            get { return item; }
            set { item = value; }
        }
        public Celula(int novo)
        {
            proximo = null;
            item = novo;
        }
        public Celula()
        {
            proximo = null;
            item = 0;
        }
    }
}
