using System;
using System.Collections.Generic;
using MVCConsole.Models;

namespace MVCConsole.Views
{
    public class Produtoview
    {
       public void Listar(List<Produto> produtos)
        {
            foreach (var item in produtos)
            {
                Console.WriteLine($"Codigo: {item.Codigo}");
                Console.WriteLine($"Produto: {item.Nome}");
                Console.WriteLine($"Preço: {item.Preco}");
                Console.WriteLine();
            }
        }  
    }
}