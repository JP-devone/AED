using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Questão03
{
    class Program
    {
        static int MaiorNumero(int [] vet,int n)
        {
            int maior;
            if(n == 1)
            {
                return vet[n-1];
            }
            else
            {
                maior = MaiorNumero(vet, n - 1);
                if (maior > vet[n - 1])
                {
                    return maior;
                }
                else
                    return vet[n - 1];
            }
        }
        static void Main(string[] args)
        {
            int[] vet = { 3, 4, 5, 6};
            Console.Write(MaiorNumero(vet,4));
            Console.ReadKey();
        }
    }
}
