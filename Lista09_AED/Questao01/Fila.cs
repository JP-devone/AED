using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Questao01
{
    internal class Fila
    {
        private Celula frente;
        private Celula tras;
        private int tamanho;

        public Fila()
        {
            Celula sentinela = new Celula();
            frente = sentinela;
            tras = sentinela;
            tamanho = 0;
        }

        public Boolean filaVazia()
        {
            if(frente.Proximo == null)
            {
                return true;
            }else
                return false;
        }
        public void Enfileirar(string novo)
        {
            Celula novaCelula = new Celula(novo);

            tras.Proximo = novaCelula;
            tras = novaCelula;
            tamanho++;
        }
        public string Desinfileirar()
        {
            string desinfileirado = "";

            if (!filaVazia())
            {
                desinfileirado = frente.Proximo.Item;
                frente = frente.Proximo;
                tamanho--;
                return desinfileirado;
            }
            else
                throw new Exception("A fila está vazia!");
            
        }
        public void exibirFila()
        {
            int cont = 1;
            Celula exibir = new Celula();
            exibir = frente;
            if (!filaVazia())
            {
                while (exibir.Proximo != null)
                {
                    string aviao = exibir.Proximo.Item;
                    Console.WriteLine($"Avião {cont}: {aviao}");
                    exibir = exibir.Proximo;
                    cont++;
                }
            }
            else
                throw new Exception("A fila está vazia!");
        }
        public string peek()
        {
            string primeiro;
            if (!filaVazia())
            {
                primeiro = frente.Proximo.Item;
                return primeiro;
            }
            else
                throw new Exception("A fila está vazia!");
        }
        public int Quantidade()
        {
            if (!filaVazia())
            {
                return tamanho;
            }
            else
                throw new Exception("A fila está vazia!");
        }


    }
}
