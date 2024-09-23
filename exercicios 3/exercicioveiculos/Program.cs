class Program
{
    static void Main(string[] args)
    {
        Veiculo veiculo1 = new Veiculo();
        Carro carro1 = new Carro(1, "vermelho", "chevrolet");
        Moto moto1 = new Moto(2, "preta", "honda", 234.44M);
        veiculo1.Buzinar();
        carro1.Buzinar();
        moto1.Buzinar();
    }
}