using System;

using System.Collections.Generic;

using System.Linq;

using System.Text;

using System.Threading.Tasks;

using System.IO;



namespace Questão03

{

    internal class Jogador

    {

        private int numero;

        private string nome;

        private string posicao;



        public string Posicao

        {

            get { return posicao; }

            set { posicao = value; }

        }



        public string Nome

        {

            get { return nome; }

            set { nome = value; }

        }



        public int Numero

        {

            get { return numero; }

            set { numero = value; }

        }

        public Jogador(int numero, string nome, string posicao)

        {

            this.numero = numero;

            this.nome = nome;

            this.posicao = posicao;

        }



    }

}