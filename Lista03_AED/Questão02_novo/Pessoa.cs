using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


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
            int dia = int.Parse(data[0]);
            int mes = int.Parse(data[1]);
            int ano = int.Parse(data[2]);
            this.data = new Data(dia,mes,ano);
            this.peso = peso;
            this.altura = altura;
        }
        public double CalcularIMC()
        {
            return peso / Math.Pow(altura, 2);
        }
    }

