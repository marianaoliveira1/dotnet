using System;

class Pessoa
{
    private string nome = "Mariana";

    public Pessoa(string nome)
    {
        Console.Write(nome+"\n");
        Console.Write(this.nome);
    }
}