using System.Collections.Generic;
using Aual34MVC.Models;
using Aual34MVC.Views;

namespace Aual34MVC.Controllers {
    public class ProdutoController {
        Produto produtoModel = new Produto ();
        ProdutoView produtoView = new ProdutoView ();

        public void Listar () {
            produtoView.MostrarNoConsole (produtoModel.Ler ());
        }

        public void Buscar (string _preco) {
            List<Produto> lista = produtoModel.Ler ().FindAll (x => x.Preco == float.Parse (_preco));
            produtoView.MostrarNoConsole (lista);
        }

    }
}