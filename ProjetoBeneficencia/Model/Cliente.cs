using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjetoBeneficencia.Model
{
    public class Cliente
    {
        public string Nome;
        public string CPF;
        public string Telefone;

        public Cliente()
        {

        }
        public Cliente(string nome, string cpf, string teleofne)
        {
            this.Nome = nome;
            this.CPF = cpf;
            this.Telefone = teleofne;

        }
    }
}
