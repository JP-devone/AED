using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Questao02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int opcao,elemento;
            ArvoreBinaria Arvore = new ArvoreBinaria();
            do
            {
                Console.WriteLine("\r\n1- Inserir um número na árvore binária de busca\r\n2- Remover um número da árvore binária de busca\r\n3- Pesquisar um número na árvore binária de busca\r\n4- Mostrar o maior elemento da árvore binária de busca\r\n5- Mostrar o menor elemento da árvore de pesquisa de busca\r\n6- Mostrar todos os elementos da árvore, usando o caminhamento central\r\n7- Mostrar todos os elementos da árvore, usando o caminhamento pós-ordem.\r\n8- Mostrar todos os elementos da árvore, usando o caminhamento pré-ordem.\r\n9- Sair");
                opcao = int.Parse(Console.ReadLine());
                switch(opcao)
                {
                    case 1:
                        Console.WriteLine("Digite o número a ser inserido: ");
                        elemento = int.Parse(Console.ReadLine());
                        Arvore.Inserir(elemento);
                        break;
                    case 2:
                        Console.WriteLine("Digite o número a ser removido: ");
                        elemento = int.Parse(Console.ReadLine());
                        Arvore.Remover(elemento);
                        break;
                    case 3:
                        Console.WriteLine("Digite o número a ser pesquisado: ");
                        elemento = int.Parse(Console.ReadLine());
                        Console.WriteLine($"O item {Arvore.Pesquisar(elemento)} foi encontrado com sucesso!!!");
                        break;
                    case 4:
                        elemento = Arvore.buscarMaior();
                        Console.WriteLine(elemento);
                        break;
                    case 5:
                        elemento = Arvore.buscarMenor();
                        Console.WriteLine(elemento);
                        break;
                    case 6:
                        Arvore.EmOrdem();
                        break;
                    case 7:
                        Arvore.PreOrdem();
                        break;
                    case 8:
                        Arvore.PosOrdem();
                        break;
                }
            } while (opcao != 9);
        }
    }
}
