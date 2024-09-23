public class ItemCarrinho
{
    public Produto Produto { get; set;}
    public int Quantidade { get; set;}
    public ItemCarrinho(Produto produto, int quantidade)
    {
        if ((produto != null) && (quantidade > 0))
        {
            Produto = produto;
            Quantidade = quantidade;
            Console.WriteLine("Item do carrinho criado com sucesso");
        }
        else
        {
            Produto = null;
            Quantidade = 0;
            Console.WriteLine("Produto ou quantidade inválidos");
        }
    }
}