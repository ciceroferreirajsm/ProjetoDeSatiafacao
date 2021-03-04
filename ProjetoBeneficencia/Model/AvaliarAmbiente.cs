using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjetoBeneficencia.Model
{
    public class AvaliarAmbiente
    {
        public string Local;
        public int Nota;
        public string Sugestao;

        public AvaliarAmbiente()
        {
        }

        public AvaliarAmbiente(string local, int nota, string sugestao)
        {
            Local = local;
            Nota = nota;
            Sugestao = sugestao;
        }
    }
}
