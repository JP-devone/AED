using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Questao01_Nativa
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int opcao;
            Queue<string> filaAviao = new Queue<string>();

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
                        Console.WriteLine($"Quantidade de aviões na fila = {filaAviao.Count()}");

                        break;
                    case 2:
                        filaAviao.Dequeue();
                        Console.WriteLine("Avião desinfileirado com sucesso!");
                        break;
                    case 3:
                        string aviao;
                        Console.Write("Digite o nome do avião: ");
                        aviao = Console.ReadLine();
                        filaAviao.Enqueue(aviao);
                        Console.WriteLine("Enfileirado!");
                        break;
                    case 4:
                        foreach (string a in filaAviao)
                        {
                            Console.WriteLine("Avião: "+a);
                        }
                        break;
                    case 5:
                        Console.WriteLine($"Primeiro a decolar: {filaAviao.Peek()}");
                        break;
                }

            } while (opcao != 6);
        }
    }
}
