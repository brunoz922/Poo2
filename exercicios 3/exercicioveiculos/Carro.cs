public class Carro : Veiculo{
    public bool Arcondicionado{get;set;}

    public bool Manual {get;set;}
    
    public Carro(int id, string cor, string marca){
        Id=id;
        Cor=cor;
        Marca=marca;
    }
    public void Buzinar(){
        Console.WriteLine("O carro está buzinando");
    }
}