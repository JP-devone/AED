using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Questao04
{
    class AgendaTelefonica
    {
        private Contato[] contatos;
        private int quant;

        public AgendaTelefonica(int tam)
        {
            contatos = new Contato[tam];
            quant = 0;
        }
        public void InserirContato(Contato contato)
        {
            if(quant < contatos.Length)
            {
                contatos[quant] = contato;
                quant++;
            }
        }
        public Contato BuscarContato(string nome)
        {
            for(int i=0; i < quant; i++)
            {
                if(contatos[i].Nome == nome)
                {
                    return contatos[i]; 
                }
            }
            return null;
     Console.WriteLine();
        }
        public void ImprimirAgenda()
        {
            for(int i=0;i< quant; i++)
            {
                Console.WriteLine(contatos[i].Nome);
                Console.WriteLine(contatos[i].Celular);
                Console.WriteLine(contatos[i].Email);
                Console.WriteLine(contatos[i].Aniversario.Dia);
                Console.WriteLine(contatos[i].Aniversario.Mes);
            }
        }
    }
}
