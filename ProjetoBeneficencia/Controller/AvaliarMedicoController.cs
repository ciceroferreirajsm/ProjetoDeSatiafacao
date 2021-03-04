using Microsoft.AspNetCore.Mvc;
using ProjetoBeneficencia.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjetoBeneficencia.Controller
{
    public class AvaliarMedicoController
    {
        public static void MedicoAvaliar()
        {
            var AvaliarMedico = new AvaliarMedico();
            Console.Write("Qual o nome do medico que voce deseja avaliar: ");
            AvaliarMedico.Nome = Console.ReadLine();
            Console.Write("Digite uma nota para o medico: ");
            AvaliarMedico.Nota = int.Parse(Console.ReadLine());
            Console.WriteLine("Deixe uma sugestão para o profissional");
            AvaliarMedico.Sugestao = Console.ReadLine();
            Console.WriteLine("Obrigado pela participação! \n\n");

        }

        /*public IActionResult Index()
        {
            return View();
        }*/
    }
}
