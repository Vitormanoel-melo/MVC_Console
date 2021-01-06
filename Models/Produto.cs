using System.Collections.Generic;
using System.IO;

namespace MVC_Console.Models
{
    public class Produto
    {
        public int Codigo { get; set; }
        public string Nome { get; set; }
        public float Preco { get; set; }
        
        private const string PATH = "Database/Produto.csv";

        public Produto(){
            // Verificar se a pasta existe

            string pasta = PATH.Split("/")[0];
            if(!Directory.Exists(pasta)){
                Directory.CreateDirectory(pasta);
            }

            // verificar se o arquivo existe
            if(!File.Exists(PATH)){
                File.Create(PATH);
            }

        }

        public List<Produto> Ler(){

            // lista para armazenar produtos
            List<Produto> produtos = new List<Produto>();
            
            // ler as linhas do CSV
            string[] linhas = File.ReadAllLines(PATH);

            // percorremos as linhas do CSV
            foreach (string item in linhas)
            {   
                string[] atributos = item.Split(";");
                // 1;JBL;5000,00
                /* [0] = 1
                   [1] = JBL
                   [3] = 5000,00
                */

                Produto prod = new Produto();
                prod.Codigo = int.Parse(atributos[0]);
                prod.Nome   = atributos[1];
                prod.Preco  = float.Parse(atributos[2]);
                
                produtos.Add(prod);
            }

            return produtos;
        }


        public void Inserir(Produto produto){
            
            // criamos um array de linhas para inserir no csv
            string[] linhas = { PrepararLinhasCSV(produto) };

            // método responsável por inserir linhas em um arquivo
            File.AppendAllLines(PATH, linhas);
        }

        public string PrepararLinhasCSV(Produto prod){

            return $"{prod.Codigo};{prod.Nome};{prod.Preco}";
        }


    }
}