using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QAuestao03
{
    internal class Turma
    {
        private int codigo;
        private int ano;

        public int Codigo
        {
            get { return codigo; }
            set { codigo = value; }
        }
        public int Ano
        {
            get { return ano; }
            set { ano = value; }
        }

        public Turma(int codigo, int ano)
        {
            this.codigo = codigo;
            this.ano = ano;
        }
        public string[] Tostring()
        {
            string[] atributos = new string[6];
            atributos[0] = this.Codigo.ToString();
            atributos[1] = this.Ano.ToString();


            return atributos;
        }

    }
}
