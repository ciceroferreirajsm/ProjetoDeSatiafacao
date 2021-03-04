using Microsoft.AspNetCore.Mvc;
using ProjetoBeneficencia.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjetoBeneficencia.Controller
{
    public class AvaliarAmbienteController 
    {
        public static void AmbienteAvaliar()
        {
            var avaliarAmbiente = new AvaliarAmbiente();
            Console.Write("Qual o local você deseja avaliar: ");
            avaliarAmbiente.Local = Console.ReadLine();
            Console.Write("Digite uma nota para o ambiente: ");
            avaliarAmbiente.Nota = int.Parse(Console.ReadLine());
            Console.WriteLine("Deixe uma sugestão para os responsáveis:");
            avaliarAmbiente.Sugestao = Console.ReadLine();
            Console.WriteLine("Obrigado pela participação! \n\n");

        }

        /*public IActionResult Index()
        {
            return View();
        }*/
    }
}
