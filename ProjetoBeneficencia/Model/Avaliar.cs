using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjetoBeneficencia.Model
{
    class Avaliar
    {
        public string Medico;
        public int Nota;
        public string Sugestao;

        public Avaliar()
        {

        }

        public Avaliar(string medico, int nota, string sugestao)
        {
            this.Medico = medico;
            this.Nota = nota;
            this.Sugestao = sugestao;
        }
    }
}
