public class Produto{
    public int Codigo{get;set;}
    public string Nome{get;set;}
    public decimal Preco{get;set;}
    public Fornecedor Fornecedor{get;set;}
    
    public Produto(int codigo, string nome, decimal preco, Fornecedor fornecedor){
        if(preco>=fornecedor.PrecoMinimo){
        Codigo=codigo;
        Nome=nome;
        Preco=preco;
        Fornecedor=fornecedor;  
        }else{
            Console.WriteLine("O fornecedor "+fornecedor.Nome+" exige um valor minimo de R$ "+fornecedor.PrecoMinimo);
        }
    }
    public void ExibirDetalhes(){
        Console.WriteLine("Codigo: " + Codigo);
        Console.WriteLine("Nome: " + Nome);
        Console.WriteLine("Preco: " + Preco);
        Console.WriteLine("Fornecedor: " + Fornecedor.Nome);
    }
}