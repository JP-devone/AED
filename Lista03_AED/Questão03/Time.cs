using System;

using System.Collections.Generic;

using System.Linq;

using System.Text;

using System.Threading.Tasks;

using System.IO;



namespace Questão03

{

    internal class Time

    {

        private string nome;

        private Jogador[] titulares;

        private Jogador[] reservas;

        private int quantTitulares;

        private int quantReservas;



        public int QuantReservas

        {

            get { return quantReservas; }

            set { quantReservas = value; }

        }





        public int QuantTitulares

        {

            get { return quantTitulares; }

            set { quantTitulares = value; }

        }





        public string Nome

        {

            get { return nome; }

            set { nome = value; }

        }

        public Time()

        {

            titulares = new Jogador[2];

            reservas = new Jogador[2];

            quantTitulares = 0;

            quantReservas = 0;

        }

        public bool AdicionarTitular(Jogador jogador)

        {

            if (quantTitulares < titulares.Length)

            {

                titulares[quantTitulares] = jogador;

                quantTitulares++;

                return true;

            }

            else

                return false;

        }

        public bool AdicionarReserva(Jogador jogador)

        {

            if (quantReservas < reservas.Length)

            {

                reservas[quantReservas] = jogador;

                quantReservas++;

                return true;

            }

            else

                return false;

        }

        public bool SubstituirTitular(string nome, Jogador jogador)

        {

            for (int i = 0; i < quantTitulares; i++)

            {

                if (titulares[i].Nome.Equals(nome))

                {

                    titulares[i] = jogador;

                    return true;

                }

            }

            return false;

        }

        public bool SubstituirReserva(string nome, Jogador jogador)

        {

            for (int i = 0; i < quantReservas; i++)

            {

                if (reservas[i].Nome.Equals(nome))

                {

                    reservas[i] = jogador;

                    return true;

                }

            }

            return false;

        }

        public bool ConsultarTitular(string nome)

        {

            for (int i = 0; i < quantTitulares; i++)

            {

                if (titulares[i].Nome.Equals(nome))

                {

                    return true;

                }

            }

            return false;

        }

        public bool ConsultarReserva(string nome)

        {

            for (int i = 0; i < quantReservas; i++)

            {

                if (reservas[i].Nome.Equals(nome))

                {

                    return true;

                }

            }

            return false;

        }

        public bool ExcluirTitular(string nome)

        {

            for (int i = 0; i < quantTitulares; i++)

            {

                if (titulares[i].Nome.Equals(nome))

                {
                    for (int j = i; j < quantTitulares -1; j++)
                    {

                        titulares[j] = titulares[j + 1];

                    }

                    quantTitulares--;

                    return true;

                }

            }

            return false;

        }

        public bool ExcluirReserva(string nome)

        {

            for (int i = 0; i < quantReservas; i++)

            {

                if (reservas[i].Nome.Equals(nome))

                {
                    for (int j = i; j < quantReservas -1; j++)
                    {
                        reservas[j] = reservas[j + 1];
                    }

                    quantReservas--;

                    return true;

                }

            }

            return false;

        }

        public void GerarArqTime(string nome)

        {

            try

            {

                StreamWriter arq = new StreamWriter(nome + ".txt", false, Encoding.UTF8);

                for (int i = 0; i < titulares.Length; i++)

                {

                    arq.WriteLine(titulares[i].Nome + "," + titulares[i].Numero + "," + titulares[i].Posicao);

                }

                for (int i = 0; i < reservas.Length; i++)

                {

                    arq.WriteLine(reservas[i].Nome + "," + reservas[i].Numero + "," + reservas[i].Posicao);

                }



                arq.Close();

            }

            catch (Exception ex)

            {

                Console.WriteLine("Ocorreu uma exceção: " + ex.Message);

            }



        }







    }

}