using System;

class Pessoa
{
    //construtor
    public Pessoa() 
    {
        Console.WriteLine("construtor executado");
    }

    public Pessoa(string nome)
    {
        Console.WriteLine("Olá, "+nome);
    }
}