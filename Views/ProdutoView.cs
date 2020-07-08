using System.Collections.Generic;
using Aual34MVC.Models;

namespace Aual34MVC.Views {
    public class ProdutoView {
        public void MostrarNoConsole (List<Produto> lista) {
            foreach (Produto item in lista) {
                System.Console.WriteLine ($"R$ {item.Preco} - {item.Nome} ");
            }
        }
    }
}