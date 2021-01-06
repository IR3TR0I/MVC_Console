using System;
using MVCConsole.Controllers;
using MVCConsole.Models;


namespace MVCConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            ProdutoController prod = new ProdutoController();
            prod.Cadastrar();
            prod.ListarProdutos();
        }
    }
}
