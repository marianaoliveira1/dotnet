using System;

namespace _13Abstracao
{
    class Program
    {
        static void Main(string[] args)
        {
           PessoaFisica pf = new PessoaFisica();
           pf.TaxaEmprestimo(1000);

           PessoaJuridica pj = new PessoaJuridica();
           pj.TaxaEmprestimo(1000);
        }
    }
}
