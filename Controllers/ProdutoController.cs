using System.Collections.Generic;
using POO34_MVC.Models;
using POO34_MVC.Views;

namespace POO34_MVC.Controllers
{
    public class ProdutoController
    {
        Produto produtoModel = new Produto();

        ProdutoView produtoView = new ProdutoView();

        public void Listar()
        {
            List<Produto> lista = produtoModel.Ler();
            produtoView.MostrarNoConsole(lista);
        }

        public void Buscar (string termo)
        {
            List<Produto> lista = produtoModel.Ler().FindAll(x => x.Preco == float.Parse(termo));
            produtoView.MostrarNoConsole(lista);
        }
    }
}