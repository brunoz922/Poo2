public class Fornecedor{
    private int _id;
    private string _nome;
    private decimal _precoMinimo;

    public int Id{
        get{return _id;}
        set{_id=value;}
    }
    public string Nome{
        get{return _nome;}
        set{_nome=value;}
    }
    public decimal PrecoMinimo{
        get{return _precoMinimo;}
        set{_precoMinimo=value;}
    }

    public Fornecedor(int id, string nome, decimal preco){
        Id=id;
        Nome=nome;
        PrecoMinimo=preco;
    }
}