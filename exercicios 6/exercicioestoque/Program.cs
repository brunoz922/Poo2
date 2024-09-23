using System;
namespace ConsoleApplication{
    class Program{
        static void Main(string[] args){
            Estoque estoque1=new Estoque();
            Produto produto1=new Produto(1, "Maçã", 9.99M, 0, "kg");
            produto1.ExibirDados();
            estoque1.AddProduto(produto1);
            Produto produto2=new Produto(2, "Pera", 12.99M, 10, "kg");
            estoque1.ListProduto();
            estoque1.AddProduto(produto2);
            estoque1.RemoveProduto(produto1);
            estoque1.ListProduto();
            estoque1.RemoveProduto(produto2);
        }
    }
}