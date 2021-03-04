using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjetoBeneficencia.Model
{
    class AvaliarMedico
    {
        public string Nome;
        public int Nota;
        public string Sugestao;

        public AvaliarMedico()
        {

        }

        public AvaliarMedico(string nome, int nota, string sugestao)
        {
            this.Nome = nome;
            this.Nota = nota;
            this.Sugestao = sugestao;
        }
    }
}
