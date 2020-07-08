using System;
using Aual34MVC.Controllers;

namespace Aual34MVC {
    class Program {
        static void Main (string[] args) {
            ProdutoController produtos = new ProdutoController ();
            produtos.Buscar ("140");
        }
    }
}