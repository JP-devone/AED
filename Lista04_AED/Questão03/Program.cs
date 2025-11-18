using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Questão03
{
    internal class Program
    {
        static void ConverteBinario(int n)
        {
           if(n > 0)
            {
                ConverteBinario(n / 2);
                Console.Write(n % 2);
            }
        }
        static void Main(string[] args)
        {
            ConverteBinario(20);
            Console.ReadKey();
        }
    }
}
