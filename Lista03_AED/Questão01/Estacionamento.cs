using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Questão01
{
    class Estacionamento
    {
        private int numTotalVagas;
        private String nome;
        private int numVagasLivres;
        private String[] vaga;

        public int NumVagasLivres
        {
            get { return numVagasLivres; }
            set { numVagasLivres = value; }
        }


        public String Nome
        {
            get { return nome; }
            set { nome = value; }
        }


        public int NumTotalVagas
        {
            get { return numTotalVagas; }
            set { numTotalVagas = value; }
        }
        public Estacionamento(String nome,int numTotalVagas)
        {
            this.nome = nome;
            this.numTotalVagas = numTotalVagas;
            this.numVagasLivres = numTotalVagas;
            vaga = new string[numTotalVagas];
        }
        public int Estacionar(String placa)
        {
            if (numVagasLivres > 0)
            {
                for (int i = 0; i < vaga.Length; i++)
                {
                    if (vaga[i] == null)
                    {
                        vaga[i] = placa;
                        numVagasLivres--;
                        return i;
                    }
                }
            }
            return -1;
        }
        public int ObterVagaOcupada(string placa)
        {
            for(int i=0; i < vaga.Length; i++)
            {
                if(vaga[i] == placa)
                {
                    return i;
                }
            }
            return -1;
        }
        public void RetirarVeiculo(String placa)
        {
            for(int i=0;i < vaga.Length; i++)
            {
                if(vaga[i] == placa)
                {
                    vaga[i] = null;
                    numVagasLivres++;
                }
            }
        }
        public int ObterNumVagasLivres()
        {
            return numVagasLivres;
        }
        public void exibirOcupacaoEstacionamento()
        {
            for(int i=0; i < vaga.Length; i++)
            {
                if(vaga[i] != null)
                {
                    Console.WriteLine("A vaga {0} tem a placa {1}", i, vaga[i]);
                }else
                    Console.WriteLine("A vaga {0} está vazia.", i, vaga[i]);


            }
        }
        

    }
}
