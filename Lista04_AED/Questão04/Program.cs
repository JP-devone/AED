using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Questão04
{
    internal class Program
    {
        static int MDC(int x, int y)
        {
            int aux;
            if (x == y)
            {
                return x;
            }
            else if (y > x)
            {
                aux = y;
                y = x;
                x = aux;
            }

            return MDC(x - y, y);

        }
        static void Main(string[] args)
        {
            Console.WriteLine("O MDC dos dois número= " + MDC(10, 6));
            Console.ReadKey();
        }
    }
}
