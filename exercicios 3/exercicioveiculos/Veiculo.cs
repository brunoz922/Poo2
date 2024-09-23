public class Veiculo{
    public int Id{get;set;}
    public string Cor{get;set;}
    public string Marca{get;set;}

    public void Buzinar(){
        Console.WriteLine("O veiculo faz barrulho!");
    }
}