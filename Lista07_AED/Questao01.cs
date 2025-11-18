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
            Stack<double> PilhaPolonesa = new Stack<double>();
            double num1, num2, resultado;
            char controle;
            do
            {
                
                do
                {
                    Console.WriteLine("Digite a expressão polonesa a ser calculada(Digite C para calcular a expressão desejada:");
                    controle = char.Parse(Console.ReadLine());
                } while (controle != '0' && controle != '1' && controle != '2' && controle != '3' && controle != '4' && controle != '5' && controle != '6' && controle != '7' && controle != '8' && controle != '9' && controle != '*' && controle != '-' && controle != '+' && controle != '/' && controle != 'C' && controle != 'c');
                switch (controle)
                {
                    case '+':
                        num1 = PilhaPolonesa.Pop();
                        num2 = PilhaPolonesa.Pop();
                        resultado = num2 + num1;
                        PilhaPolonesa.Push(resultado);
                        break;
                    case '-':
                        num1 = PilhaPolonesa.Pop();
                        num2 = PilhaPolonesa.Pop();
                        resultado = num2 - num1;
                        PilhaPolonesa.Push(resultado);
                        break;
                    case '*':
                        num1 = PilhaPolonesa.Pop();
                        num2 = PilhaPolonesa.Pop();
                        resultado = num2 * num1;
                        PilhaPolonesa.Push(resultado);
                        break;
                    case '/':
                        num1 = PilhaPolonesa.Pop();
                        num2 = PilhaPolonesa.Pop();
                        resultado = num2 / num1;
                        PilhaPolonesa.Push(resultado);
                        break;
                    default:
                        if(controle != 'C' && controle != 'c')
                        {
                            PilhaPolonesa.Push((double)Char.GetNumericValue(controle));
                        }
                        break;
                }


            } while (controle != 'C' && controle != 'c');
            Console.WriteLine("A expressão polonesa = "+ PilhaPolonesa.Pop());
            Console.ReadKey();
        }
    }
}
