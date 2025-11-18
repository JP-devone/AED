using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


    class Data
    {
        private int dia;
        private int mes;
        private int ano;

        public int Dia
        {
            get { return dia; }
            set { dia = value; }
        }
        public int Mes
        {
            get { return mes; }
            set { mes = value; }
        }
        public int Ano
        {
            get { return ano; }
            set { ano = value; }
        }
        public Data(int dia, int mes, int ano)
        {
            this.dia = dia;
            this.mes = mes;
            this.ano = ano;
        }
        public int CalcularIdade()
        {
            int idade;
            idade = 2023 - ano;
            return idade;
        }
    }

