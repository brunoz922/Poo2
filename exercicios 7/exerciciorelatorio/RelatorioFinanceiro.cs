public class RelatorioFinanceiro{
    public List<Transacao> transacoes;

    public RelatorioFinanceiro(){
        transacoes=new List<Transacao>();
    }
    public void addTransacao(Transacao transacao){
        transacoes.Add(transacao);
    }
    public void removeTransacao(Transacao transacao){
        transacoes.Remove(transacao);
    }
    public decimal CalcularSaldo(){
        decimal saldo=0;
        foreach(Transacao transacao in transacoes){
            if(transacao.Entrada){
                saldo+=transacao.Valor;
            }else{
                saldo-=transacao.Valor;
            }
        }
        return saldo;
    }
}