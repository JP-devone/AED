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
            Stack<string> PilhaBemFormado = new Stack<string>();
            string controle;
            do
            {
                Console.WriteLine("Digite a sequência que desejar(Aperte a letra 'S' para sair):");
                controle = Console.ReadLine();

                if (controle == "(" || controle == "[")
                {
                    PilhaBemFormado.Push(controle);
                }
                else if (controle == ")" && PilhaBemFormado.Count != 0)
                {
                    PilhaBemFormado.Pop();
                }
                else if (controle == "]" && PilhaBemFormado.Count != 0)
                {
                    PilhaBemFormado.Pop();
                }
                else if (controle == "]" && PilhaBemFormado.Count == 0)
                {
                    PilhaBemFormado.Push(controle);
                }
                else if(controle == ")" && PilhaBemFormado.Count == 0)
                {
                    PilhaBemFormado.Push(controle);
                }
                controle.ToLower();
            } while (controle != "s");
            if (PilhaBemFormado.Count == 0)
            {
                Console.WriteLine("A sequência está bem-formada!");
            }
            else
                Console.WriteLine("A sequência não está bem-formada!");
            Console.ReadKey();
        }
    }
}
