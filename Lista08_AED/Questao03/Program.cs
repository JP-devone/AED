using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Questao03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            PilhaEncadeada PilhaOctalEncadeada = new PilhaEncadeada();
            int numero;
            Console.WriteLine("Digite o número que deseja converter para octal: ");
            numero = int.Parse(Console.ReadLine());

            while (numero > 0)
            {
                PilhaOctalEncadeada.Empilhar(numero % 8);
                numero /= 8;
            }
            Console.Write("O número em Octal = ");
            while (!PilhaOctalEncadeada.PilhaVazia())
            {
                Console.Write(PilhaOctalEncadeada.Desempilhar());
            }
            Console.ReadKey();
        }
    }
}
