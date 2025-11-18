using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Questao02_02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Pilha PilhaBemFormado;
            int tamanho;
            string controle;
            Console.WriteLine("Digite o tamanho da sequência: ");
            tamanho = int.Parse(Console.ReadLine());
            PilhaBemFormado = new Pilha(tamanho);
            for(int i = 0;i < tamanho;i++)
            {
                Console.WriteLine("Digite a sequência:");
                controle = Console.ReadLine();

                if (controle == "(" || controle == "[")
                {
                    PilhaBemFormado.empilhar(controle);
                }
                else if (controle == ")" && !PilhaBemFormado.pilhaVazia())
                {
                    PilhaBemFormado.desempilhar();
                }
                else if (controle == "]" && !PilhaBemFormado.pilhaVazia())
                {
                    PilhaBemFormado.desempilhar();
                }
                else if (controle == "]" && PilhaBemFormado.pilhaVazia())
                {
                    PilhaBemFormado.empilhar(controle);
                }
                else if (controle == ")" && PilhaBemFormado.pilhaVazia())
                {
                    PilhaBemFormado.empilhar(controle);
                }            
            }
            if (PilhaBemFormado.pilhaVazia())
            {
                Console.WriteLine("A sequência está bem-formada!");
            }
            else
                Console.WriteLine("A sequência não está bem-formada!");
            Console.ReadKey();

        }
    }
}
