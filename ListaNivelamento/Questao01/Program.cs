using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Questao01
{
    class Program
    {
        static void PreencherMatriz(double[,] mat)
        {
            Random aleatorio = new Random();
            for (int i = 0;i < mat.GetLength(0); i++)
            {
                for(int j = 0; j < mat.GetLength(1); j++)
                {
                    mat[i, j] = aleatorio.Next(1, 100);
                }
            }
        }
        static void ImprimirMatriz(double[,] mat)
        {
            double[] mes = new double[11];
            double ano = 0;
            int [] 
            for (int i = 0; i < mat.GetLength(0); i++)
            {
                for (int j = 0; j < mat.GetLength(1); j++)
                {
                    Console.Write(mat[i, j]+" ");
                    mes[i] += mat[i, j];
                    ano += mat[i, j];
                }

               Console.WriteLine();
            }
        }
        static void Main(string[] args)
        {
            double[,] mat = new double[12,4];
            PreencherMatriz(mat);
            ImprimirMatriz(mat);

            Console.ReadKey();
        }
    }
}

