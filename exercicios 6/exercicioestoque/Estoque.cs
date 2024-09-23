public class Estoque{

    private List<Produto> produtos;
    
    public Estoque(){
        produtos= new List<Produto>();
    }
    public void AddProduto(Produto produto){
        produtos.Add(produto);
        Console.WriteLine("Item adicionado com sucesso");

    }
    public void RemoveProduto(Produto produto){
        produtos.Remove(produto);
        Console.WriteLine("Item removido com sucesso");

    }
    public void ListProduto(){
        Console.WriteLine("Produtos em estoque: ");
        foreach(Produto produto in produtos){
            produto.ExibirDados();
        }
    }

}