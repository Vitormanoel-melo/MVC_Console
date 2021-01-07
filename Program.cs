using System;
using MVC_Console.Controller;
using MVC_Console.Models;

namespace MVC_Console
{
    class Program
    {

        static void Main(string[] args)
        {

            ProdutoController prod = new ProdutoController();
            prod.Cadastrar();
            prod.ListarProdutos();

            ClienteController cli = new ClienteController();
            cli.GerarDataBase();
            cli.Cadastrar();
            cli.ExibirClientes();

        }
    }
}
