using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Questao01
{
    class Program
    {
        static void Main(string[] args)
        {
            int opcao;
            Fila filaAviao = new Fila();

            do
            {
                Console.WriteLine("1. Listar a quantidade de aviões que estão aguardando na fila de decolagem" +
                                 "\r\n2. Autorizar a decolagem do primeiro avião da fila de decolagem (isto é, retirar da fila de decolagem)" +
                                 "\r\n3. Adicionar um avião na fila de decolagem" +
                                 "\r\n4. Listar todos os aviões que estão na fila de decolagem" +
                                 "\r\n5. Exibir o primeiro avião da fila de decolagem\r\n6. Sair");
                opcao = int.Parse(Console.ReadLine());

                switch (opcao)
                {
                    case 1:
                        Console.WriteLine($"Quantidade de aviões na fila = {filaAviao.Quantidade()}");

                        break;
                    case 2:
                        filaAviao.Desinfileirar();
                        Console.WriteLine("Avião desinfileirado com sucesso!");
                        break;
                    case 3:
                        string aviao;
                        Console.Write("Digite o nome do avião: ");
                        aviao = Console.ReadLine();
                        filaAviao.Enfileirar(aviao);
                        Console.WriteLine("Enfileirado!");
                        break;
                    case 4:
                        filaAviao.exibirFila();
                        break;
                    case 5:
                        Console.WriteLine($"Primeiro a decolar: {filaAviao.peek()}");
                        break;
                }

            } while (opcao != 6);
        }
    }
}
