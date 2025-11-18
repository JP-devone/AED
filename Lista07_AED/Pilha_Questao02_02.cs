using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Questao02_02
{
    internal class Pilha
    {
        private string[] pilha;
        private int topo;

        public Pilha(int tamanho)
        {
            pilha = new string[tamanho];
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
        public string desempilhar()
        {

            string desempilhado;

            if (!pilhaVazia())
            {
                topo--;
                desempilhado = pilha[topo];
                return desempilhado;
            }
            else
                throw new Exception("Não foi possível desempilhar: a pilha está vazia!");
        }

        public void empilhar(string novo)
        {

            if (!pilhaCheia())
            {
                pilha[topo] = novo;
                topo++;
            }
            else
                throw new Exception("Não foi possível empilhar: a pilha está cheia!");
        }

        public string consultarTopo()
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
