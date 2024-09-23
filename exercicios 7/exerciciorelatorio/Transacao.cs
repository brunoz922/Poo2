public class Transacao{
    public decimal Valor{get;set;}
    public bool Entrada{get;set;}

    public Transacao(decimal valor, bool entrada){
        Valor=valor;
        Entrada=entrada;
    }
}