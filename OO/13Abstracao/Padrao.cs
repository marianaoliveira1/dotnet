
using System;

abstract class Padrao
{
    public abstract void TaxaEmprestimo(double valor);

    public void CalculoPoupanca(double valor, double taxa)
    {
        Console.WriteLine("Ganhos obtidos pela poupanca R$ " +(valor*taxa));
    }
}