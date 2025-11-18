using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace QAuestao03
{
    internal class Aluno
    {
        private string nome;
        private int idade;
        private double peso;
        private bool formando;
        private char sexo;
        private Turma turma;

        public string Nome
        {
            get { return nome; }
            set { nome = value; }
        }
        public int Idade
        {
            get { return idade; }
            set { idade = value; }
        }
        public double Peso
        {
            get { return peso; }
            set { peso = value; }
        }
        public bool Formando
        {
            get { return formando; }
            set { formando = value; }
        }
        public char Sexo
        {
            get { return sexo; }
            set { sexo = value; }
        }
        public Turma Turma
        {
            get { return turma; }
            set { turma = value; }
        }

        public Aluno(string nome, int idade, double peso, char sexo, Turma turma)
        {
            this.nome = nome;
            this.idade = idade;
            this.peso = peso;
            this.sexo = sexo;
            formando = false;
            this.turma = turma;
        }
        public string [] Tostring()
        {
           string [] atributos = new string[7];
            atributos[0] = this.nome;
            atributos[1] = this.idade.ToString();
            atributos[2]  = this.peso.ToString();
            atributos[3] = this.sexo.ToString();
            atributos[4] = this.formando.ToString();
            atributos[5] = this.turma.Codigo.ToString();
            atributos[6] = this.turma.Ano.ToString();

            return atributos;
        }
    }
}
