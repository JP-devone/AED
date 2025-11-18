using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;



namespace Questão03

{

    internal class Program

    {

        static void Main(string[] args)

        {

            Jogador ronaldo = new Jogador(12, "Ronaldo", "Centroavante");
            Jogador ronaldinho = new Jogador(8, "Ronaldinho", "Meio-campista");
            Jogador casemiro = new Jogador(20, "Casemiro", "Volante");
            Jogador messi = new Jogador(10, "Messi", "Atacante");
            Jogador cristiano = new Jogador(10, "Cristiano Ronaldo", "Atacante");
            Jogador neymar = new Jogador(10, "Neymar", "Atacante");

            Time Barcelona = new Time();

            Barcelona.AdicionarTitular(ronaldinho);
            Barcelona.AdicionarTitular(cristiano);
            Barcelona.AdicionarReserva(casemiro);
            Barcelona.AdicionarReserva(ronaldo);
            Barcelona.SubstituirTitular("Cristiano Ronaldo", messi);
            Barcelona.SubstituirReserva("Casemiro", neymar);
            if (Barcelona.ConsultarTitular("Messi"))
            {
                Console.WriteLine("O jogador está no time titular.");
            }
            if (Barcelona.ConsultarReserva("Ronaldo"))
            {
                Console.WriteLine("O jogador está como reserva.");
            }
            if (Barcelona.ExcluirTitular("Messi"))
            {
                Console.WriteLine("Jogador titular excluído com sucesso!!");
            }
            if (Barcelona.ExcluirReserva("Neymar"))
            {
                Console.WriteLine("Jogador reserva excluído com sucesso!!");
            }
            Barcelona.GerarArqTime("Barcelona");
            Console.ReadKey();
        }

    }

}