using System;
using System.Collections.Generic;
using MVC_Console.Models;

namespace MVC_Console.Views
{
    public class ClienteView
    {
        public Cliente CadastrarCliente(){
            
            Cliente cliente = new Cliente();

            Console.WriteLine("Digite o Nome: ");
            cliente.Nome = Console.ReadLine();
            
            Console.WriteLine("Digite a idade: ");
            cliente.Idade = int.Parse(Console.ReadLine());
            
            Console.WriteLine("Digite o CPF: ");
            cliente.Cpf = Console.ReadLine();
            
            Console.WriteLine();

            return cliente;
        }

        public void ListarClientes(List<Cliente> cliente){
            
            foreach (var item in cliente)
            {   
                Console.WriteLine($"Nome: {item.Nome}");
                Console.WriteLine($"Idade {item.Idade}");
                Console.WriteLine($"CPF {item.Cpf}");
                Console.WriteLine();
            }

        }

    }
}