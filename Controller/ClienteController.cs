using MVC_Console.Models;
using MVC_Console.Views;

namespace MVC_Console.Controller
{
    public class ClienteController
    {
        Cliente cliente = new Cliente();

        ClienteView clienteView = new ClienteView();

        public void GerarDataBase(){
            Cliente cliente = new Cliente();
        }

        public void Cadastrar(){
            cliente.Inserir( clienteView.CadastrarCliente() );
        }

        public void ExibirClientes(){
            clienteView.ListarClientes( cliente.CriarLista() );
        }

    }
}