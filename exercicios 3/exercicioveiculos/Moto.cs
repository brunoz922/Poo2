public class Moto : Veiculo{
    public decimal Quilometragem{get;set;}

    
    public Moto(int id, string cor, string marca, decimal quilometragem){
        Id=id;
        Cor=cor;
        Marca=marca;
        Quilometragem=quilometragem;
    }
    public void Buzinar(){
        Console.WriteLine("A moto está buzinando");
    }
}