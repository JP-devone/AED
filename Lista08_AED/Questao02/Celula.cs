using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Questao02
{
    internal class Celula
    {
        private Celula proximo;
        private string item;
        public Celula Proximo
        {
            get { return proximo; }
            set { proximo = value; }
        }
        public string Item
        {
            get { return item; }
            set { item = value; }
        }
        public Celula(string novo)
        {
            proximo = null;
            item = novo;
        }
        public Celula()
        {
            proximo = null;
            item = null;
        }
    }
}
