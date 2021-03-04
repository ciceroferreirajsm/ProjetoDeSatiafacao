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
            //to do
            //controller
        }
        private static string CaminhoBaseClientes()
        {
            return ConfigurationManager.AppSettings["BaseDeClientes"];
        }

        public static void CadastrarClientes()
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
        public static List<Cliente> LerClientes()
        {
            var clientes = new List<Cliente>();
            if (File.Exists(CaminhoBaseClientes()))
            {
                using StreamReader arquivo = File.OpenText(CaminhoBaseClientes());
                string linha;
                int i = 0;
                while ((linha = arquivo.ReadLine()) != null)
                {
                    i++;
                    if (i == 1)
                        continue;
                    var clienteArquivo = linha.Split(';');

                    var cliente = new Cliente(clienteArquivo[0], clienteArquivo[1], clienteArquivo[2]);

                    clientes.Add(cliente);
                }

            }
            return clientes;

        }

        /*public IActionResult Index()
        {
            return View();
        }*/
    }
}
