using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Questão02
{
    internal class Program
    {
        static int intervalo(int m, int n)
        {
            if(m == n)
            {
                return m;
            }
            if(m < n)
            {
                return intervalo(m+1,n)+m;
            }else
                return intervalo(m-1,n)+m;
        }
        static void Main(string[] args)
        {
            int soma;
            soma = intervalo(7,4);
            Console.WriteLine(soma);
            Console.ReadKey();

        }
    }
}
