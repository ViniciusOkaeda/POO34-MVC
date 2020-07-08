using System.Collections.Generic;
using POO34_MVC.Models;

namespace POO34_MVC.Views
{
    public class ProdutoView
    {
        public void MostrarNoConsole(List<Produto> lista)
        {
            foreach (Produto item in lista)
            {
                System.Console.WriteLine($"R$: {item.Preco} - {item.Nome} ");
            }
        }
    }
}