using System;

namespace _11Polimorfismo
{
    class Program
    {
        static void Main(string[] args)
        {
            Imposto objetoE = new Estagiario();
            objetoE.ValeAlimentacao(1000);
            objetoE.ValeTransporte(1000);
            Console.WriteLine("--------");


            Imposto objetoG = new Gerente();
            objetoG.ValeAlimentacao(5000);
            objetoG.ValeTransporte(5000);
            Console.WriteLine("--------");

            Imposto objetoA = new Atendente();
            objetoA.ValeAlimentacao(2000);
            objetoA.ValeTransporte(2000);
            Console.WriteLine("--------");
        }
    }
}
