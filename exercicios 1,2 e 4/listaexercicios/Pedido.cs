public class Pedido{
    public int Id{get;set;}
    public DateTime Data{get;set;}
    public Cliente Cliente{get;set;}
    public Carrinho Carrinho{get;set;}
    
    public Pedido(int id, Cliente cliente, Carrinho carrinho){
        Id = id;
        Cliente = cliente;
        Carrinho = carrinho;
        Data = DateTime.Now;
    }
    public decimal Total()
    {
        Carrinho.CalcTotalCarrinho();
        return Carrinho.Total;
    }
}