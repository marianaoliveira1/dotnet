
using System;

class PessoaJuridica : Padrao
{
    public override void taxaEmprestimo(double valor)
    {
        Console.WriteLine("Taxa de emprestimo para Pesspa Juridica R$ " +(valor*0.2));
    }
}
