using Microsoft.AspNetCore.Mvc;
using ProjetoBeneficencia.Model;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace ProjetoBeneficencia.Controller
{
    public class ClienteController
    {
        public static void GravarCliente()
        {
            var clientes = CadastrarClientes();
            string linha = "";
            if (File.Exists(CaminhoBaseClientes()))
            {
                StreamWriter r = new StreamWriter(CaminhoBaseClientes());
                r.WriteLine("nome;telefone;cpf");
                foreach (Cliente c in clientes)
                {
                    linha += c.Nome + ";" + c.Telefone + ";" + c.CPF + ";\n";
                }
                r.Close();
            }
            
        }
        private static string CaminhoBaseClientes()
        {
            return ConfigurationManager.AppSettings["BaseDeClientes"];
        }

        public static List<Cliente> CadastrarClientes()
        {
            var clientes = new List<Cliente>();
            var cliente = new Cliente();
            
            Console.WriteLine("Primeiramente precisaremos do seu cadastro!");
            Console.WriteLine("Qual seu nome: ");
            cliente.Nome = Console.ReadLine();
            Console.WriteLine("Seu telefone: ");
            cliente.Telefone = Console.ReadLine();
            Console.WriteLine("Seu CPF: ");
            cliente.CPF = Console.ReadLine();

            clientes.Add(cliente);

            return clientes;
        }
        /*public IActionResult Index()
        {
            return View();
        }*/
    }
}
