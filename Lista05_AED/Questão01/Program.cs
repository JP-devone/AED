using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Questão01
{
    class Program
    {
        static int Soma(int n)
        {
            if(n == 1)
            {
                return n;
            }
            return Soma(n - 1) + n;
        }
        static void Main(string[] args)
        {
            Console.WriteLine(Soma(5));
            Console.ReadKey();
        }
    }
}
