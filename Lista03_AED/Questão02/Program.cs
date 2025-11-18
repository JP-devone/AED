using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Questão02
{
    class Program
    {
        static void Main(string[] args)
        {
            string linha,dataNasci;
            string[] atributos = new string[3];
            double peso, altura;
            string opcao;
            try
            {
                StreamReader arq = new StreamReader("C:\\Users\\1205493\\source\\repos\\Lista03_AED\\Pessoa.txt", Encoding.UTF8);
                linha = arq.ReadLine();
                while(linha != null)
                {
                    atributos = linha.Split(':');
                    peso = double.Parse(atributos[1]);
                    altura = double.Parse(atributos[2]);
                    Pessoa pessoa1 = new Pessoa(atributos[0], peso, altura);
                    linha = arq.ReadLine();
                }
                arq.Close();
            }catch(Exception e)
            {
                Console.WriteLine("Excessão: " + e.Message);
            }
            Console.WriteLine("Deseja cadastrar uma nova pessoa?(S,N):");
            opcao = Console.ReadLine();
            opcao.ToLower();
            while(opcao == "s")
            {
                Console.WriteLine("Digite a sua data de nascimento dividio por '/' :");
                dataNasci = Console.ReadLine();
                Console.WriteLine("Digite seu peso:");
                peso = double.Parse(Console.ReadLine());
                Console.WriteLine("Digite seu peso:");
                altura = double.Parse(Console.ReadLine());
                Pessoa pessoa = new Pessoa(dataNasci, peso, altura);
                StreamWriter arq = new StreamWriter("C:\\Users\\1205493\\source\\repos\\Lista03_AED\\Pessoa.txt", true, Encoding.UTF8);
                arq.WriteLine(dataNasci+":"+ peso+":"+altura);
                Console.WriteLine("Deseja cadastrar uma nova pessoa?(S,N):");
                opcao = Console.ReadLine();
                opcao.ToLower();
            }
        }
    }
}
