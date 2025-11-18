using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Questao01
{
    class Program
    {
       
        static void BubblesortCrescente(int[] vet)
        {
            int aux;
            for(int i = vet.Length-1; i > 0; i--)
            {
                for(int j = 0; j < vet.Length - 1; j++)
                {
                    if(vet[j] > vet[j + 1])
                    {
                        aux = vet[j + 1];
                        vet[j + 1] = vet[j];
                        vet[j] = aux;
                    }
                }
            }
            Console.WriteLine("Método ordenado:");
            for (int i = 0; i < vet.Length; i++)
            {
                Console.Write(" " + vet[i]);
            }
        }
        static void BubblesortDecrescente(int[] vet)
        {
            int aux;
            for (int i = vet.Length - 1; i > 0; i--)
            {
                for (int j = 0; j < vet.Length - 1; j++)
                {
                    if (vet[j] < vet[j + 1])
                    {
                        aux = vet[j + 1];
                        vet[j + 1] = vet[j];
                        vet[j] = aux;
                    }
                }
            }
            Console.WriteLine("Método ordenado:");
            for (int i = 0; i < vet.Length; i++)
            {
                Console.Write(" " + vet[i]);
            }
        }
        static void SelecaoCrescente(int[] vet)
        {
            
            int menor,aux;
            for(int i = 0; i < vet.Length; i++)
            {
                menor = i;
                for(int j = i+1; j < vet.Length-1; j++)
                {
                    if(vet[j] < vet[menor])
                    {
                        menor = j;
                    }
                }
                aux = vet[menor];
                vet[menor] = vet[i];
                vet[i] = aux;
            }
            Console.WriteLine("Método ordenado:");
            for (int i = 0; i < vet.Length; i++)
            {
                Console.Write(" " + vet[i]);
            }
        }
        static void SelecaoDecrescente(int[] vet)
        {
            int maior, aux;
            for (int i = 0; i < vet.Length; i++)
            {
                maior = i;
                for (int j = i + 1; j < vet.Length - 1; j++)
                {
                    if (vet[j] > vet[maior])
                    {
                        maior = j;
                    }
                }
                aux = vet[maior];
                vet[maior] = vet[i];
                vet[i] = aux;
            }
            Console.WriteLine("Método ordenado:");
            for (int i = 0; i < vet.Length; i++)
            {
                Console.Write(" " + vet[i]);
            }
        }
        static void InsercaoCrescente(int[] vet)
        {
            int temp;
            int j;
            for (int i = 1; i < vet.Length; i++)
            {
                temp = vet[i];
                for(j = i-1;j >= 0 && vet[j] > temp; j--)
                {
                    vet[j + 1] = vet[j];
                }
                vet[j+1] = temp;
            }
            Console.WriteLine("Método ordenado:");
            for (int i = 0; i < vet.Length; i++)
            {
                Console.Write(" "+vet[i]);
            }
        }
        static void InsercaoDecrescente(int[] vet)
        {
            int temp;
            int j;
            for (int i = 1; i < vet.Length; i++)
            {
                temp = vet[i];
                for (j = i - 1; j >= 0 && vet[j] < temp; j--)
                {
                    vet[j + 1] = vet[j];
                }
                vet[j + 1] = temp;
            }
            Console.WriteLine("Método ordenado:");
            for (int i = 0; i < vet.Length; i++)
            {
                Console.Write(" " + vet[i]);
            }
        }
        static void QuickSortCrescente(int[] vet,int inicio,int fim)
        {
            int part;
            if(inicio < fim)
            {
                part = particao(vet,inicio,fim);
                QuickSortCrescente(vet,inicio,part-1);
                QuickSortCrescente(vet,part+1,fim);
            }
        }
        static int particao(int[] vet, int inicio,int fim)
        {
            int pivo = vet[fim];
            int part = inicio - 1;
            int aux;
            for(int i = inicio;i < fim; i++)
            {
                if (vet[i] < pivo)
                {
                    
                    part ++;
                    aux = vet[i];
                    vet[i] = vet[part];
                    vet[part] = aux;
                }
            }
            part ++;
            aux = vet[part];
            vet[part] = pivo;
            vet[fim] = aux;

            return part;
        }
        static void QuickSortDecrescente(int[] vet, int inicio, int fim)
        {

            int part;
            if (inicio < fim)
            {
                part = particaoDecrescente(vet, inicio, fim);
                QuickSortDecrescente(vet, inicio, part - 1);
                QuickSortDecrescente(vet, part + 1, fim);

            }
        }
        static int particaoDecrescente(int[] vet, int inicio, int fim)
        {
            
            int pivo = vet[fim];
            int part = inicio - 1;
            int aux;
            for (int i = inicio; i < fim; i++)
            {
                if (vet[i] > pivo)
                {
                    
                    part++;
                    aux = vet[i];
                    vet[i] = vet[part];
                    vet[part] = aux;
                }
            }
            part++;
            aux = vet[part];
            vet[part] = pivo;
            vet[fim] = aux;
           

            return part;
        }

        static void Main(string[] args)
        {
            int opcao,tamanho;
            string metodo;
            Random aleatorio = new Random();
            int[] vet;
            do
            {
                Console.WriteLine("\n1) Algoritmo Seleção\n2) Algoritmo da Bolha(Bubblesort)\n3) Algoritmo de Inserção\n4) Quicksort\n5) Para sair");
                opcao = int.Parse(Console.ReadLine());
                switch (opcao)
                {
                    case 1:
                        Console.WriteLine("Escreva em que ordem deseja usar, Crescente ou Decrescente?");
                        metodo = Console.ReadLine();
                        metodo.ToLower();
                        if(metodo == "crescente")
                        {
                            Console.WriteLine("Digite o tamanho a ordenar: ");
                            tamanho = int.Parse(Console.ReadLine());
                            vet = new int[tamanho];
                            for(int i = 0; i < tamanho; i++)
                            {
                                vet[i] = aleatorio.Next(1,10);
                            }
                            SelecaoCrescente(vet);
                        }else if(metodo == "decrescente")
                        {
                            Console.WriteLine("Digite o tamanho a ordenar: ");
                            tamanho = int.Parse(Console.ReadLine());
                            vet = new int[tamanho];
                            for (int i = 0; i < tamanho; i++)
                            {
                                vet[i] = aleatorio.Next(1, 10);
                            }
                            SelecaoDecrescente(vet);
                        }
                        break;
                    case 2:
                        Console.WriteLine("Escreva em que ordem deseja usar, Crescente ou Decrescente?");
                        metodo = Console.ReadLine();
                        metodo.ToLower();
                        if (metodo == "crescente")
                        {
                            Console.WriteLine("Digite o tamanho a ordenar: ");
                            tamanho = int.Parse(Console.ReadLine());
                            vet = new int[tamanho];
                            for (int i = 0; i < tamanho; i++)
                            {
                                vet[i] = aleatorio.Next(1, 10);
                            }
                            BubblesortCrescente(vet);
                        }
                        else if (metodo == "decrescente")
                        {
                            Console.WriteLine("Digite o tamanho a ordenar: ");
                            tamanho = int.Parse(Console.ReadLine());
                            vet = new int[tamanho];
                            for (int i = 0; i < tamanho; i++)
                            {
                                vet[i] = aleatorio.Next(1, 10);
                            }
                            BubblesortDecrescente(vet);
                        }
                        break;
                    case 3:
                        Console.WriteLine("Escreva em que ordem deseja usar, Crescente ou Decrescente?");
                        metodo = Console.ReadLine();
                        metodo.ToLower();
                        if (metodo == "crescente")
                        {
                            Console.WriteLine("Digite o tamanho a ordenar: ");
                            tamanho = int.Parse(Console.ReadLine());
                            vet = new int[tamanho];
                            for (int i = 0; i < tamanho; i++)
                            {
                                vet[i] = aleatorio.Next(1, 10);
                            }
                            InsercaoCrescente(vet);
                        }
                        else if (metodo == "decrescente")
                        {
                            Console.WriteLine("Digite o tamanho a ordenar: ");
                            tamanho = int.Parse(Console.ReadLine());
                            vet = new int[tamanho];
                            for (int i = 0; i < tamanho; i++)
                            {
                                vet[i] = aleatorio.Next(1, 10);
                            }
                            InsercaoDecrescente(vet);
                        }
                        break;
                    case 4:
                        Console.WriteLine("Escreva em que ordem deseja usar, Crescente ou Decrescente?");
                        metodo = Console.ReadLine();
                        metodo.ToLower();
                        if (metodo == "crescente")
                        {
                            Console.WriteLine("Digite o tamanho a ordenar: ");
                            tamanho = int.Parse(Console.ReadLine());
                            vet = new int[tamanho];
                            for (int i = 0; i < tamanho; i++)
                            {
                                vet[i] = aleatorio.Next(1, 10);
                            }
                            QuickSortCrescente(vet,0,tamanho-1);
                            Console.WriteLine("Método ordenado:");
                            for (int i = 0; i < vet.Length; i++)
                            {
                                Console.Write(" " + vet[i]);
                            }
                        }
                        else if (metodo == "decrescente")
                        {
                            Console.WriteLine("Digite o tamanho a ordenar: ");
                            tamanho = int.Parse(Console.ReadLine());
                            vet = new int[tamanho];
                            for (int i = 0; i < tamanho; i++)
                            {
                                vet[i] = aleatorio.Next(1, 10);
                            }
                            QuickSortDecrescente(vet, 0, tamanho-1);
                            Console.WriteLine("Método ordenado:");
                            for (int i = 0; i < vet.Length; i++)
                            {
                                Console.Write(" " + vet[i]);
                            }
                        }
                        break;
                }
            } while (opcao != 5);
           
            Console.ReadKey();
        }
    }
}
