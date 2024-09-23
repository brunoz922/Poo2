public class Produto{
    private int _id;
    private string _nome;
    private decimal _preco;
    private int _quantidade;
    private string _unidadeMedida;

    public int Id{
        get{return _id;}
        set{_id=value;}
    }
    public string Nome{
        get{return _nome;}
        set{_nome=value;}
    }public decimal Preco{
        get{return _preco;}
        set{_preco=value;}
    }public int Quantidade{
        get{return _quantidade;}
        set{_quantidade=value;}
    }public string UnidadeMedida{
        get{return _unidadeMedida;}
        set{_unidadeMedida=value;}
    }


    public Produto(int id, string nome, decimal preco, int quantidade, string unidade){
        Id=id;
        Nome=nome;
        Preco=preco;
        Quantidade=quantidade;
        UnidadeMedida=unidade;
    }


    public void ExibirDados(){
        Console.WriteLine("Id: "+Id);
        Console.WriteLine("Nome: "+Nome);
        Console.WriteLine("Preco: "+Preco);
        Console.WriteLine("Quantidade: "+Quantidade);
        Console.WriteLine("Unidade de medida: "+UnidadeMedida);

    }
}