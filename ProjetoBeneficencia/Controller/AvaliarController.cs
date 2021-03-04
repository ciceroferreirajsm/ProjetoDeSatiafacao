using Microsoft.AspNetCore.Mvc;
using ProjetoBeneficencia.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjetoBeneficencia.Controller
{
    public class AvaliarController
    {
        public static void MedicoAvaliar()
        {
            var avaliar = new Avaliar();
            Console.Write("Qual o nome do medico que voce deseja avaliar: ");
            avaliar.Medico = Console.ReadLine();
            Console.Write("Digite uma nota para o medico: ");
            avaliar.Nota = int.Parse(Console.ReadLine());
            Console.WriteLine("Deixe uma sugestão para o profissional");
            avaliar.Sugestao = Console.ReadLine();
            Console.WriteLine("Obrigado pela participação! \n\n");

        }

        /*public IActionResult Index()
        {
            return View();
        }*/
    }
}
