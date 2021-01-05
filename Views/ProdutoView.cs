using System;
using System.Collections.Generic;
using MVC_Console.Models;

namespace MVC_Console.Views
{
    public class ProdutoView
    {
        public void Listar(List<Produto> produtos){
            foreach (Produto item in produtos)
            {
                Console.WriteLine($"Código: {item.Codigo} ");
                Console.WriteLine($"Código: {item.Nome} ");
                Console.WriteLine($"Código: R$ {item.Preco} ");
                Console.WriteLine();
            }
        }

    }
}