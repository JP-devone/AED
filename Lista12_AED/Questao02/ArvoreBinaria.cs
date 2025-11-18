using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Questao02
{
    internal class ArvoreBinaria
    {
        private No raiz;

        public ArvoreBinaria()
        {
            raiz = null;
        }
        public void Inserir(int novo)
        {
            this.raiz = Inserir(this.raiz,novo);
        }
        private No Inserir(No RaizSubArvore,int novo)
        {
            if(RaizSubArvore == null)
            {
                RaizSubArvore = new No(novo);
            }
            else if(RaizSubArvore.Item == novo)
            {
                throw new Exception("Nao foi possível inserir o valor.O item já existe dentro da árvore!");
            }
            else if(novo > RaizSubArvore.Item)
            {
                RaizSubArvore.Direita = Inserir(RaizSubArvore.Direita,novo);
            }else
                RaizSubArvore.Esquerda = Inserir(RaizSubArvore.Esquerda,novo);

            return RaizSubArvore;
        }
        public int Pesquisar(int chave)
        {
            return Pesquisar(this.raiz, chave);
        }
        private int Pesquisar(No RaizSubArvore, int chave)
        {
            if(RaizSubArvore == null)
            {
                throw new Exception("O item pesquisado não existe na arvore!");
            }
            else if(chave == RaizSubArvore.Item)
            {
                return RaizSubArvore.Item;
            }
            else if(chave > RaizSubArvore.Item)
            {
                return Pesquisar(RaizSubArvore.Direita, chave);
            }
            else
                return Pesquisar(RaizSubArvore.Esquerda , chave);
        }
        public void Remover(int remover)
        {
            this.raiz = Remover(this.raiz, remover);
        }
        private No Remover(No raizSubArvore, int remover)
        {
            if(raizSubArvore == null)
            {
                throw new Exception("Nao foi possível remover! O item nao existe na arvore!");
            }
            else if(raizSubArvore.Item == remover)
            {
                if (raizSubArvore.Esquerda == null)
                {
                    raizSubArvore = raizSubArvore.Direita;
                }
                else if (raizSubArvore.Direita == null)
                {
                    raizSubArvore = raizSubArvore.Esquerda;
                }
                else
                    raizSubArvore.Esquerda = antecessor(raizSubArvore, raizSubArvore.Esquerda);
            }
            else if(remover > raizSubArvore.Item)
            {
                raizSubArvore.Direita = Remover(raizSubArvore.Direita, remover);
            }
            else
                raizSubArvore.Esquerda = Remover(raizSubArvore.Esquerda, remover);

            return raizSubArvore;
        }
        private No antecessor(No retirado,No raizSubArvore)
        {
            if(raizSubArvore.Direita != null)
            {
                raizSubArvore.Direita = antecessor(retirado, raizSubArvore.Direita);
            }
            else
            {
                retirado.Item = raizSubArvore.Item;
                raizSubArvore = raizSubArvore.Esquerda;
            }
            return raizSubArvore;
        }
        public int buscarMaior()
        {
            return buscarMaior(this.raiz);
        }
        private int buscarMaior(No raizSubArvore)
        {
            if (raizSubArvore == null)
            {
                throw new Exception("Árvore vazia!");
            }
            else if (raizSubArvore.Direita == null)
            {
                return raizSubArvore.Item;
            }
            else
                return buscarMaior(raizSubArvore.Direita);
        }
        public int buscarMenor()
        {
            return buscarMenor(this.raiz);
        }
        private int buscarMenor(No raizSubArvore)
        {
            if (raizSubArvore == null)
            {
                throw new Exception("Árvore vazia!");
            }
            else if (raizSubArvore.Esquerda == null)
            {
                return raizSubArvore.Item;
            }
            else
                return buscarMenor(raizSubArvore.Esquerda);
        }
        public void EmOrdem()
        {
            EmOrdem(this.raiz);
        }
        private void EmOrdem(No subArvore)
        {
            if(subArvore != null)
            {
                EmOrdem(subArvore.Esquerda);
                Console.Write(" " + subArvore.Item);
                EmOrdem(subArvore.Direita);
            }           
        }
        public void PreOrdem()
        {
            PreOrdem(this.raiz);
        }
        private void PreOrdem(No subArvore)
        {
            if (subArvore != null)
            {                
                PreOrdem(subArvore.Esquerda);               
                PreOrdem(subArvore.Direita);
                Console.Write(" " + subArvore.Item);
            }
        }
        public void PosOrdem()
        {
            PosOrdem(this.raiz);
        }
        private void PosOrdem(No subArvore)
        {
            if (subArvore != null)
            {
                Console.Write(" " + subArvore.Item);
                PosOrdem(subArvore.Esquerda);
                PosOrdem(subArvore.Direita);
            }
        }





    }
}
