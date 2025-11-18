using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Questao04
{
    class Contato
    {
        private string nome;
        private string celular;
        private string email;
        private Data aniversario;

        public string Nome
        {
            get { return nome; }
            set { nome = value; }
        }
        public string Celular
        {
            get { return celular; }
            set { celular = value; }
        }
        public string Email
        {
            get { return email; }
            set { email = value; }
        }
        public Data Aniversario
        {
            get { return aniversario; }
            set { aniversario = value; }
        }
        
        public Contato(string nome,string celular,string email, int dia, int mes)
        {
            this.nome = nome;
            this.celular = celular;
            this.email = email;
            aniversario = new Data(dia, mes);
        }
        public Contato(string nome, string celular, string email, Data aniversario)
        {
            this.nome = nome;
            this.aniversario = aniversario;
            this.celular = celular;
            this.email = email;
        }
    }
}
