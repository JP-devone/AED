using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Questão01._2
{
    internal class Pilha
    {
        private double[] pilha;
        private int topo;

        public Pilha(int tamanho)
        {
            pilha = new double[tamanho];
            topo = 0;
        }
        public Boolean pilhaCheia()
        {

            Boolean resp;

            if (topo == pilha.Length)
                resp = true;
            else
                resp = false;

            return resp;
        }

        public Boolean pilhaVazia()
        {

            Boolean resp;

            if (topo == 0)
                resp = true;
            else
                resp = false;

            return resp;
        }
        public double desempilhar()
        {

            double desempilhado;

            if (!pilhaVazia())
            {
                topo--;
                desempilhado = pilha[topo];
                return desempilhado;
            }
            else
                throw new Exception("Não foi possível desempilhar: a pilha está vazia!");
        }

        public void empilhar(double novo)
        {

            if (!pilhaCheia())
            {
                pilha[topo] = novo;
                topo++;
            }
            else
                throw new Exception("Não foi possível empilhar: a pilha está cheia!");
        }

        public double consultarTopo()
        {

            if (!pilhaVazia())
            {
                return (pilha[topo - 1]);
            }
            else
                throw new Exception("Não foi possível consultar o elemento do topo da pilha: a pilha está vazia!");
        }

    }
}
