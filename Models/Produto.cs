using System;
using System.Collections.Generic;
using System.IO;
namespace MVCConsole.Models
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
            if(!Directory.Exists(pasta))
            {
                Directory.CreateDirectory(pasta);
            }

            //Verificar se o arquivo existe
            if(!File.Exists(PATH))
            {
                File.Create(PATH);
            }
        }

        
        public List<Produto> Ler()
        {
            List<Produto> produtos = new List<Produto>();

            string[] Linhas = File.ReadAllLines(PATH);

            //Percorremos as linhas do csv
            foreach (string item in Linhas)
            {
                //Separamos os elementos
                string[] atributos = item.Split(";");

                // Passando para um objeto tipo produto
                Produto prod = new Produto();
                prod.Codigo = int.Parse( atributos[0] );
                prod.Nome = atributos[1];
                prod.Preco = float.Parse( atributos[2] );
                produtos.Add(prod);

            }
            return produtos;
        }
    }
}