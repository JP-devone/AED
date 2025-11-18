using Questao01;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

internal class TesteAluno
{
    static void Main(string[] args)
    {
        string nome, formando;
        int idade;
        double peso;
        char sexo;

        Console.WriteLine("Digite o nome do aluno= ");
        nome = Console.ReadLine();
        Console.WriteLine("Digite a idade do aluno= ");
        idade = int.Parse(Console.ReadLine());
        Console.WriteLine("Digite o peso do aluno= ");
        peso = double.Parse(Console.ReadLine());
        Console.WriteLine("Digite o sexo do aluno= ");
        sexo = char.Parse(Console.ReadLine());

        Aluno aluno01 = new Aluno(nome, idade,peso,sexo);

        Console.WriteLine(aluno01.Nome);
        Console.WriteLine(aluno01.Idade);
        Console.WriteLine(aluno01.Peso);
        Console.WriteLine(aluno01.Sexo);

        Console.WriteLine("Digite a idade do aluno= ");
        idade = int.Parse(Console.ReadLine());
        aluno01.Idade = idade;
        Console.WriteLine("Digite o peso do aluno= ");
        peso = double.Parse(Console.ReadLine());
        aluno01.Peso = peso;
        Console.WriteLine("O aluno está formando? ");
        formando = Console.ReadLine();
        formando = formando.ToLower();
        if(formando == "sim")
        {
            aluno01.Formando = true;
        } else
            aluno01.Formando = false;

        Console.WriteLine(aluno01.Nome);
        Console.WriteLine(aluno01.Idade);
        Console.WriteLine(aluno01.Peso);
        Console.WriteLine(aluno01.Sexo);
        Console.WriteLine(aluno01.Formando);

        Console.ReadKey();
    }
}


