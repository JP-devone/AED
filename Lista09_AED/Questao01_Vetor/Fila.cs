using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Questao01_Vetor
{
    class Fila
    {
        private int frente;
        private int tras;
        private int tamanho;
        private int count;
        private string[] vet;

        public Fila(int tamanho)
        {
            vet = new string[tamanho];
            frente = 0;
            tras = 0;
            count = 0;
            this.tamanho = tamanho;
        }

        public Boolean filaVazia()
        {
            if (frente == tras)
            {
                return true;
            }
            else
                return false;
        }
        public Boolean filaCheia()
        {
            if ((tras + 1) % tamanho == frente)
            {
                return true;
            }
            else
                return false;
        }
        public void Enfileirar(string novo)
        {
            if (!filaCheia())
            {
                vet[tras] = novo;
                tras++;
                count++;
            }
            else
                throw new Exception("A fila está cheia!");
        }
        public string Desinfileirar()
        {
            string desinfileirado = "";

            if (!filaVazia())
            {
                desinfileirado = vet[frente];
                frente++;
                count--;
                return desinfileirado;
            }
            else
                throw new Exception("A fila está vazia!");

        }
        public void exibirFila()
        {
            
            if (!filaVazia())
            {
               for(int i=frente; i < tras; i= (i+1)%tamanho)
                {
                    Console.WriteLine($"Avião: {vet[i]}");
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
                primeiro = vet[frente];
                return primeiro;
            }
            else
                throw new Exception("A fila está vazia!");
        }
        public int Quantidade()
        {
            if (!filaVazia())
            {
                return count;
            }
            else
                throw new Exception("A fila está vazia!");
        }
    }
}
