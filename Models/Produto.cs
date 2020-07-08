using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace POO34_MVC.Models
{
    public class Produto
    {
        public int Codigo { get; set; }

        public string Nome { get; set; }

        public float Preco { get; set; }

        public const string PATH = "Database/Produto.csv";


         public Produto(){
            string pasta = PATH.Split('/')[0];
            
            //verifica se existe o diretório pasta, se nao existir ele cria o mesmo
            if(!Directory.Exists(pasta)){
            Directory.CreateDirectory(pasta);
            }
            if(!File.Exists(PATH))
            {
                File.Create(PATH).Close();
            }
        }
            List<Produto> Listar()
        {
            // Lemos o arquivo e transformamos em um array de linhas
            List<Produto> produtos = new List<Produto>();
            
            string[] linhas = File.ReadAllLines(PATH);

            foreach(string linha in linhas){
                
                // Separamos os dados de cada linha com Split

                string[] dados = linha.Split(";");

                // Criamos instâncias de produtos para serem colocados na lista
                Produto prod = new Produto();
                prod.Codigo = Int32.Parse (SepararDado (dados[0]) );
                prod.Nome = SepararDado (dados[1] );
                prod.Preco = float.Parse (SepararDado(dados[2]) );

                produtos.Add(prod);
            }
            // ordena o nome dos contatos por ordem alfabética
            produtos = produtos.OrderBy(y => y.Nome).ToList();
            return produtos; 
        }
        private string SepararDado(string txt){
            return txt.Split('=')[1];
        }
    }
}