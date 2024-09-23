using System;
namespace ConsoleApplication{
    class Program{
        static void Main(string[] args){
            RelatorioFinanceiro relatorio1 = new RelatorioFinanceiro();
            Transacao transacao1=new Transacao(100.00M, true);
            Transacao transacao2=new Transacao(200.00M, false);
            Transacao transacao3=new Transacao(300.00M, true);
            Transacao transacao4=new Transacao(5000.00M, true);
           relatorio1.addTransacao(transacao1);
           relatorio1.addTransacao(transacao2);
           relatorio1.addTransacao(transacao3);
           relatorio1.addTransacao(transacao4);
           Console.WriteLine(relatorio1.CalcularSaldo());
        }
    }
}