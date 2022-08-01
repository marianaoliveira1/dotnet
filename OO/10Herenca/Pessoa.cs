using System;

class Pessoa
{
    protected string nome;
    protected int idade;

    protected void MensagemPessoa()
    {
        Console.WriteLine("nome: " +nome);
        Console.WriteLine("nome: " +idade);
    }
}