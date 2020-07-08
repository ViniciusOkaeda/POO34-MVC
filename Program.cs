using System;
using POO34_MVC.Controllers;
using POO34_MVC.Views;

namespace POO34_MVC
{
    class Program
    {
        static void Main(string[] args)
        {
            ProdutoController produtos = new ProdutoController();
            produtos.Buscar("5500");
        }
    }
}
