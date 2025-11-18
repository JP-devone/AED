using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Questao01
{
    internal class Aluno
    {
        private string nome;
        private int idade;
        private double peso;
        private bool formando;
        private char sexo;

        public Aluno(string nome, int idade, double peso, char sexo)
        {
            this.nome = nome;
            this.idade = idade;
            this.peso = peso;
            this.sexo = sexo;
            formando = false;
        }
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

    }
}