using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Questao01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            PilhaEncadeada PilhaPolonesa;
            int tamanho;
            Console.WriteLine("Digite o tamanho da expressão: ");
            tamanho = int.Parse(Console.ReadLine());
            PilhaPolonesa = new PilhaEncadeada();
            float num1, num2, resultado;
            char controle;
            for (int i = 0; i < tamanho; i++)
            {

                do
                {
                    Console.WriteLine("Digite a expressão polonesa a ser calculada(Digite C para calcular a expressão desejada:");
                    controle = char.Parse(Console.ReadLine());
                } while (controle != '0' && controle != '1' && controle != '2' && controle != '3' && controle != '4' && controle != '5' && controle != '6' && controle != '7' && controle != '8' && controle != '9' && controle != '*' && controle != '-' && controle != '+' && controle != '/');
                switch (controle)
                {
                    case '+':
                        num1 = PilhaPolonesa.Desempilhar();
                        num2 = PilhaPolonesa.Desempilhar();
                        resultado = num2 + num1;
                        PilhaPolonesa.Empilhar(resultado);
                        break;
                    case '-':
                        num1 = PilhaPolonesa.Desempilhar();
                        num2 = PilhaPolonesa.Desempilhar();
                        resultado = num2 - num1;
                        PilhaPolonesa.Empilhar(resultado);
                        break;
                    case '*':
                        num1 = PilhaPolonesa.Desempilhar();
                        num2 = PilhaPolonesa.Desempilhar();
                        resultado = num2 * num1;
                        PilhaPolonesa.Empilhar(resultado);
                        break;
                    case '/':
                        num1 = PilhaPolonesa.Desempilhar();
                        num2 = PilhaPolonesa.Desempilhar();
                        resultado = num2 / num1;
                        PilhaPolonesa.Empilhar(resultado);
                        break;
                    default:
                        PilhaPolonesa.Empilhar((float)Char.GetNumericValue(controle));
                        break;
                }
            }
            Console.WriteLine("A expressão polonesa = " + PilhaPolonesa.Desempilhar());
            Console.ReadKey();

        }
    }
}
