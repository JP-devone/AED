using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QAuestao03
{
    internal class TesteAluno
    {
        static void Main(string[] args)
        {
            Turma t1 = new Turma(001,2023);
            Aluno alun01 = new Aluno("João Pedro",23,59,'M',t1);

            Console.WriteLine(alun01.Idade);
            Console.WriteLine(alun01.Peso);
            alun01.Idade = 18;
            alun01.Peso = 70;
            Console.WriteLine(alun01.Idade);
            Console.WriteLine(alun01.Peso);
            for(int i = 0; i < 7; i++)
            {
                string [] atributos = alun01.Tostring();
                Console.WriteLine(atributos[i]);
            }
            Console.ReadKey();
        }
    }
}
