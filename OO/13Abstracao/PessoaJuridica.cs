
using System;

class PessoaJuridica : Padrao
{
    public override void TaxaEmprestimo(double valor)
    {
        Console.WriteLine("Taxa de emprestimo para Pesspa Juridica R$ " +(valor*0.2));
    }
}
