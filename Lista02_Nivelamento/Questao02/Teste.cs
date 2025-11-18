using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Questao02
{
    internal class Teste
    {
        static void Main(string[] args)
        {
            Cliente cliente1 = new Cliente(001, "Lucas");
            Cliente cliente2 = new Cliente(002, "Luiz");
            Cliente cliente3 = new Cliente(003, "João");

            Console.WriteLine(cliente1.getNome());
            Console.WriteLine(cliente2.getNome());
            Console.Write(cliente3.getNome());

            Console.WriteLine(cliente1.AtualizarCredito(300));
            cliente1.AtualizarCategoria(true);
            Console.WriteLine(cliente1.AtualizarCredito(300));

            Console.ReadKey();

        }
    }
}
