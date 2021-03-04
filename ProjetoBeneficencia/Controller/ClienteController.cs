using Microsoft.AspNetCore.Mvc;
using ProjetoBeneficencia.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjetoBeneficencia.Controller
{
    public class ClienteController 
    {
        public static void Gravar()
        {
            //to do
            //controller
        }
        public void CadastrarClientes()
        {
            var cliente = new Cliente();

            Console.WriteLine("Primeiramente precisaremos do seu cadastro!");
            Console.WriteLine("Qual seu nome: ");
            cliente.Nome = Console.ReadLine();
            Console.WriteLine("Seu telefone: ");
            cliente.Telefone = Console.ReadLine();
            Console.WriteLine("Seu CPF: ");
            cliente.CPF = Console.ReadLine();


        }

        /*public IActionResult Index()
        {
            return View();
        }*/
    }
}
