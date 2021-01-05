using System.Collections.Generic;
using MVCConsole.Models;
using MVCConsole.Views;

namespace MVCConsole.Controllers
{
    public class ProdutoController
    {
        Produto produto = new Produto();  
      Produtoview produtoView = new Produtoview();

      public void ListarProdutos()
      {
          produtoView.Listar(produto.Ler());
      }
    }
}