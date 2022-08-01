
using System;

class PessoaFisica : Padrao
{
    public override void TaxaEmprestimo(double valor)
    {
        Console.WriteLine("Taxa de emprestimo para Pesspa Fisica R$ " +(valor*0.1));
    }
}