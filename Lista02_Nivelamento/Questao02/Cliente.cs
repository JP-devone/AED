using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Questao02
{
    internal class Cliente
    {
        private int codigo;
        private string nome;
        private bool eClienteEspecial;
        private double limiteCredito;

        public Cliente(int codigo, string nome)
        {
            this.codigo = codigo;
            this.nome = nome;
            limiteCredito = 0;
            eClienteEspecial = false;
        }
        public string getNome()
        {
            return nome;
        }
        public bool AtualizarCredito(double limiteCredito)
        {
            if (eClienteEspecial)
            {
                this.limiteCredito = limiteCredito;
                return true;
            }
            else
                return false;
        }
        public void AtualizarCategoria(bool categoria)
        {
            if (categoria)
            {
                this.eClienteEspecial = categoria;
            }
            else
                limiteCredito = 0;
        }

    }
}
