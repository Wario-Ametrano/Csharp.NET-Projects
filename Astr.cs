using System;


namespace MyNamespace
{

internal class Astr
{
        
    public static void Main(string[] args)
    {
        ContoCorrente conto = new ContoCorrente();
        EstrattoConto estratto = new EstrattoConto();
        conto = estratto;
        ContiBanca contiBancari = conto;
        contiBancari.CalcSaldo();
    }
    public abstract class ContiBanca
    {
        string sede;
        public abstract float Saldo {get;set;}
        public abstract void CalcSaldo();
        
    }
    public interface Contabilita
    {
        float Saldo {get;set;}
        public void CalcSaldoDisp();
    }
    public class ContoCorrente:ContiBanca,Contabilita
    {
        float saldo;
        float prelievo;
        public override float Saldo {get;set;}
        public float NuovoSaldo {get{return saldo + prelievo;}set { saldo = disponibilita;}}
        public override void CalcSaldo()
        {
            Console.WriteLine("calcolo del saldo")
        }
        public void CalcSaldoDisp()
        {
            Console.WriteLine("Calcolo del saldo disponibile");
        }
    }
    public class EstrattoConto:ContoCorrente
    {

    }





}
}