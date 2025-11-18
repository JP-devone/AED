using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Questão02
{
    class Pessoa
    {
        private Data data;
        private double peso;
        private double altura;

        public Data Data
        {
            get { return data; }
            set { data = value; }
        }
        public double Peso
        {
            get { return peso; }
            set { peso = value; }
        }
        public double Altura
        {
            get { return altura; }
            set { altura = value; }
        }

        public Pessoa(string dat, double peso, double altura)
        {
            string[] data = new string[3];
            data = dat.Split('/');
            this.data.Dia = int.Parse(data[0]);
            this.data.Mes = int.Parse(data[1]);
            this.data.Ano = int.Parse(data[2]);
            this.peso = peso;
            this.altura = altura;
        }
        public double CalcularIMC()
        {
            return peso / Math.Pow(altura,2);
        }
    }
}
