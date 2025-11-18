using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Questao02_Vetor
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Fila impressao = new Fila(3);
            int opcao;
            do
            {
                Console.WriteLine("1. Inserir arquivo na fila de impressão\r\n2. Executar impressão\r\n3. Exibir fila de impressão\r\n4. Sair");
                opcao = int.Parse(Console.ReadLine());
                switch (opcao)
                {
                    case 1:
                        Arquivo arquivo;
                        Console.Write("Digite o nome do arquivo: ");
                        string nome = Console.ReadLine();
                        Console.Write("Digite o número de páginas: ");
                        int numero = int.Parse(Console.ReadLine());
                        arquivo = new Arquivo(nome, numero);
                        impressao.Enfileirar(arquivo);
                        break;
                    case 2:
                        impressao.Desinfileirar();
                        Console.WriteLine("Arquivo impresso!");
                        break;
                    case 3:
                        impressao.exibirFila();
                        break;
                }
            } while (opcao != 4);
        }
    }
}
