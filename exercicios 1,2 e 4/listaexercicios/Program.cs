// See https://aka.ms/new-console-template for more information
using System;
namespace ConsoleApplication{
    class Program{
        static void Main(string[] args){
            //testando cliente
            Cliente cliente1= new Cliente("italo", "italosantos@gmail.com","(18) 98804-2311");
            cliente1.ExibirDetalhes();
            //testando fornecedor
            Fornecedor fornecedor1= new Fornecedor(1, "Tomatudo", 9.99M);
            //testando produto
            Produto produto1= new Produto(1,"Amaciante",10.00M, fornecedor1);
            produto1.ExibirDetalhes();
            Produto produto2= new Produto(2,"Sabão",5.00M, fornecedor1);
            Produto produto3= new Produto(3,"Condicionador",18.00M, fornecedor1);
            //testando item carrinho
            ItemCarrinho item1= new ItemCarrinho(produto1, 2);
            ItemCarrinho item2= new ItemCarrinho(produto2, 10);
            ItemCarrinho item3= new ItemCarrinho(produto3, 3);
            //testando carrinho
            Carrinho carrinho1= new Carrinho();
            carrinho1.AdicionarItem(item1);
            carrinho1.AdicionarItem(item3);
            carrinho1.AdicionarItem(item2);
            carrinho1.RemoverItem(1);
            //testando pedido
            Pedido pedido1= new Pedido(1,cliente1,carrinho1);
            Console.WriteLine("Total do pedido: " +pedido1.Total());
        }
    }
}

