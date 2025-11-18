using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Questao02_Vetor
{
    internal class Fila
    {
        private int frente;
        private int tras;
        private int tamanho;
        private int count;
        private Arquivo[] vet;

        public Fila(int tamanho)
        {
            vet = new Arquivo[tamanho];
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
        public void Enfileirar(Arquivo novo)
        {
            if (!filaCheia())
            {

                vet[tras % tamanho] = novo;
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
                desinfileirado = vet[frente % tamanho].Nome;
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
                int posicao;
                int cont = 1;
                for (int i = frente; i < tras; i++,cont++)
                {
                    posicao = i % tamanho;
                    string arquivo = vet[i].Nome;
                    Console.WriteLine($"Arquivo {cont}: {arquivo}");
                    Console.WriteLine($"Número de páginas: {vet[i].Num_paginas}");
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
                primeiro = vet[frente].Nome;
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
