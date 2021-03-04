using Microsoft.AspNetCore.Mvc;
using ProjetoBeneficencia.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjetoBeneficencia.Controller
{
    public class MenuController
    {
        public const int AVALIAR_MEDICO = 0;
        public const int ENCERRAR_PROGRAMA = 1;

        public static void Criar()
        {
            var cadastro = new Cliente();
            Console.WriteLine(cadastro.Nome);

            while (true)
            {
                string mensagem = "Bem vindo ao sistema de avaliação hospitalar" +
                    "\n 0 - Para avaliar um médico: " +
                    "\n 1 - Para sair do sistema: ";

                Console.WriteLine(mensagem);

                int valor = int.Parse(Console.ReadLine());

                if (valor == AVALIAR_MEDICO)
                {
                    AvaliarController.MedicoAvaliar();
                }
                else if (valor == ENCERRAR_PROGRAMA)
                {
                    Console.WriteLine("Obrigado por participar, te esperamos em breve");
                    break;
                }
                else
                {
                    Console.WriteLine("Opção digitada inválida!");
                    Console.WriteLine("Digite uma opção abaixo:\n");
                }
            }
            /*public IActionResult Index()
            {
                return View();
            }*/
        }
    }
}