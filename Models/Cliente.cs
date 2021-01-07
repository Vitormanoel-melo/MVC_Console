using System.Collections.Generic;
using System.IO;

namespace MVC_Console.Models
{
    public class Cliente
    {
        public string Nome { get; set; }
        public int Idade { get; set; }
        public string Cpf { get; set; }
        // public string email { get; set; }
        
        public const string PATH = "Database/Cliente.csv";
        
        public Cliente(){
            
            string arquivo = PATH.Split("/")[0];

            if(!Directory.Exists(arquivo)){
                Directory.CreateDirectory(arquivo);
            }

            if(!File.Exists(PATH)){
                File.Create(PATH);
            }

        }
        
        public void Inserir(Cliente cliente){
            
            // criamos um array de linhas para inserir no csv
            string[] linhas = { PrepararLinhasCSV(cliente) };

            // método responsável por inserir linhas em um arquivo
            File.AppendAllLines(PATH, linhas);
        }

        public string PrepararLinhasCSV(Cliente cliente){

            return $"{cliente.Nome};{cliente.Idade};{cliente.Cpf}";
        }
        
        public List<Cliente> CriarLista(){
            List<Cliente> cliente = new List<Cliente>();

            string[] linhasCliente = File.ReadAllLines(PATH);
            foreach (string item in linhasCliente)
            {   
                string[] atributosCliente = item.Split(";");

                Cliente c = new Cliente();

                c.Nome = atributosCliente[0];
                c.Idade = int.Parse(atributosCliente[1]);
                c.Cpf = atributosCliente[2];

                cliente.Add(c);
            }


            return cliente;
        }

        
    }
}