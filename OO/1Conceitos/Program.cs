using System;

namespace OO
{
    class Program
    {
        static void Main(string[] args)
        {
            Pessoa obj = new Pessoa();
            obj.nome = "mariana";
            obj.idade = 21;

            obj.mensagem();

        }
    }
}
