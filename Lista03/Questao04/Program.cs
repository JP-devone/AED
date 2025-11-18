using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Questao04
{
    class Program
    {
        static void Main(string[] args)
        {
            AgendaTelefonica agenda = new AgendaTelefonica(100);
            Contato temp = new Contato("maria", "999", "maria@puc", 7, 11);
            agenda.InserirContato(temp);
            Data dataTemp = new Data(4, 8);
            agenda.InserirContato(new Contato("João", "888", "joao@puc", dataTemp));
            agenda.InserirContato(new Contato("José", "666", "jose@puc", dataTemp));

        }
    }
}
