using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Questao01
{
    internal class Celula
    {
        private Celula proximo;
        private float item;
        public Celula Proximo
        {
            get { return proximo; }
            set { proximo = value; }
        }
        public float Item
        {
            get { return item; }
            set { item = value; }
        }
        public Celula(float novo)
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
