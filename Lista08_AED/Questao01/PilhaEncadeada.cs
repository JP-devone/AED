using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Questao01
{
    internal class PilhaEncadeada
    {
        private Celula topo;
        private Celula fundo;

        public PilhaEncadeada()
        {
            Celula sentinela = new Celula();
            topo = sentinela;
            fundo = sentinela;
        }

        public Boolean PilhaVazia()
        {
            if (topo == fundo)
            {
                return true;
            }else
                return false;
        }

        public void Empilhar(float novo)
        {
            Celula novaCelula = new Celula();
            novaCelula.Item = novo;
            novaCelula.Proximo = topo;
            topo = novaCelula;
        }

        public float Desempilhar()
        {
            float Desempilhado;
            if (!PilhaVazia())
            {
                Desempilhado = topo.Item;
                topo = topo.Proximo;
                return Desempilhado;
            }
            else
                throw new Exception("A pilha está vazia! Não é possível desempilhar");
        }
        public float Consultar()
        {
            if (!PilhaVazia())
            {
                return topo.Item;
            }
            else
                throw new Exception("A pilha está vazia! Não existe um topo");
        }
    }
}
