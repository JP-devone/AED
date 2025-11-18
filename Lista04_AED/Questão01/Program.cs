using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Questão01
{
    internal class Program
    {
        static int potencia(int a, int n)
        {
            if(n == 1)
            {
                return a;
            }
            return potencia(a, n - 1) * a;
        }
        static void Main(string[] args)
        {
            int teste;
            teste = potencia(3,3);
            Console.WriteLine(teste);
            Console.ReadKey();
        }
    }
}
