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
            PilhaEncadeada PilhaBemFormado;
            int tamanho;
            string controle;
            Console.WriteLine("Digite o tamanho da sequência: ");
            tamanho = int.Parse(Console.ReadLine());
            PilhaBemFormado = new PilhaEncadeada();
            for (int i = 0; i < tamanho; i++)
            {
                Console.WriteLine("Digite a sequência:");
                controle = Console.ReadLine();

                if (controle == "(" || controle == "[")
                {
                    PilhaBemFormado.Empilhar(controle);
                }
                else if (controle == ")" && !PilhaBemFormado.PilhaVazia() && PilhaBemFormado.Consultar() == "(")
                {
                    PilhaBemFormado.Desempilhar();
                }
                else if (controle == "]" && !PilhaBemFormado.PilhaVazia() && PilhaBemFormado.Consultar() == "[")
                {
                    PilhaBemFormado.Desempilhar();
                }
                else if (controle == "]" && PilhaBemFormado.PilhaVazia())
                {
                    PilhaBemFormado.Empilhar(controle);
                }
                else if (controle == ")" && PilhaBemFormado.PilhaVazia())
                {
                    PilhaBemFormado.Empilhar(controle);
                }
            }
            if (PilhaBemFormado.PilhaVazia())
            {
                Console.WriteLine("A sequência está bem-formada!");
            }
            else
                Console.WriteLine("A sequência não está bem-formada!");
            Console.ReadKey();
        }
    }
}
