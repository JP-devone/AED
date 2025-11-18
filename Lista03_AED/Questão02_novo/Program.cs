using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

class Program
{
    static void Main(string[] args)
    {
        string linha, dataNasci;
        string[] atributos = new string[3];
        double peso, altura;
        string opcao,aux;
        try
        {
            StreamReader arq = new StreamReader("Pessoa.txt", Encoding.UTF8);
            linha = arq.ReadLine();
            while (linha != null)
            {
                atributos = linha.Split(':');
                peso = double.Parse(atributos[1]);
                altura = double.Parse(atributos[2]);
                Pessoa pessoa1 = new Pessoa(atributos[0], peso, altura);
                Console.WriteLine("Idade = {0} IMC = {1}", pessoa1.Data.CalcularIdade(), pessoa1.CalcularIMC().ToString("F"));
                linha = arq.ReadLine();
            }
            arq.Close();
        }
        catch (Exception e)
        {
            Console.WriteLine("Excessão: " + e.Message);
        }
        Console.WriteLine("Deseja cadastrar uma nova pessoa?(S,N):");
        aux = Console.ReadLine();
        opcao = aux.ToLower();
        while (opcao == "s")
        {
            Console.WriteLine("Digite a sua data de nascimento utilizando a  '/' :");
            dataNasci = Console.ReadLine();
            Console.WriteLine("Digite seu peso:");
            peso = double.Parse(Console.ReadLine());
            Console.WriteLine("Digite a sua altura:");
            altura = double.Parse(Console.ReadLine());
            Pessoa pessoa = new Pessoa(dataNasci, peso, altura);
            try
            {
                StreamWriter arq = new StreamWriter("Pessoa.txt",true, Encoding.UTF8);
                arq.WriteLine(dataNasci + ":" + peso + ":" + altura.ToString("F"));
                arq.Close();
            }catch (Exception e)
            {
                Console.WriteLine("Ocorreu uma exceção: "+e.Message);
            }
            Console.WriteLine("Idade = {0} IMC = {1}", pessoa.Data.CalcularIdade(), pessoa.CalcularIMC().ToString("F"));
            Console.WriteLine("Deseja cadastrar uma nova pessoa?(S,N):");
            aux = Console.ReadLine();
            opcao = aux.ToLower();
        }
        Console.ReadKey();
    }
}

