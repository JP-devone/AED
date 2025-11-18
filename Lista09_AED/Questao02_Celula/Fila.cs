using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Questao02_Celula
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
            if (frente.Proximo == null)
            {
                return true;
            }
            else
                return false;
        }
        public void Enfileirar(Arquivo novo)
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
                desinfileirado = frente.Proximo.Item.Nome;
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
                    string arquivo = exibir.Proximo.Item.Nome;
                    Console.WriteLine($"Arquivo {cont}: {arquivo}");
                    Console.WriteLine($"Número de páginas: {exibir.Proximo.Item.Num_paginas}");
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
                primeiro = frente.Proximo.Item.Nome;
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
