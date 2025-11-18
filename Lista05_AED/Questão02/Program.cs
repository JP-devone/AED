using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Questão02
{
    class Program
    {
        static void Crescente(int n)
        {
            if(n == 0)
            {
                Console.Write(0);
            }
            else
            {
                Crescente(n - 1);
                Console.Write(n);
            }
        }
        static void Main(string[] args)
        {
            Crescente(5);
            Console.ReadKey();
        }
    }
}
