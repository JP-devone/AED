using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Questao01
{
    internal class Program
    {
        static int pesquisaBinaria(int[] vet, int chave,int inicio,int fim)
        {
            int meio = inicio + fim /2;
            if (inicio > fim)
            {
                return -1;
            }
            else if (chave == vet[meio])
            {
                return meio;
            }
            else if (chave > vet[meio])
            {
                return pesquisaBinaria(vet, chave, meio + 1, fim);
            }
            else if (chave < vet[meio])
            {
                return pesquisaBinaria(vet, chave, inicio, meio - 1);
            }
            else
                return -1;
        }
        static void Main(string[] args)
        {
            int elemento, tam, pesquisa;
            Console.WriteLine("Digite o tamanho do vetor: ");
            tam = int.Parse(Console.ReadLine());
            int[] vet = new int[tam];
            for (int i = 0; i < tam; i++)
            {
                Console.WriteLine($"Digite o valor da posiçao {i + 1}:");
                elemento = int.Parse(Console.ReadLine());
                vet[i] = elemento;
            }
            Console.WriteLine("Digite o elemento procurado:");
            pesquisa = int.Parse(Console.ReadLine());
            Console.WriteLine(pesquisaBinaria(vet, pesquisa,0,tam));
            Console.ReadKey();

        }
    }
}
