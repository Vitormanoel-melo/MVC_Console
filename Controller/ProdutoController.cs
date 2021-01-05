using System.Collections.Generic;
using MVC_Console.Models;
using MVC_Console.Views;

namespace MVC_Console.Controller
{
    public class ProdutoController
    {
        // Models
        Produto produto = new Produto();

        // Views
        ProdutoView produtoview = new ProdutoView();

        public void ListarProdutos(){
            produtoview.Listar(produto.Ler());
        }
        

    }
}