using System;

namespace _2Metodos
{
    class Program
    {
        static void Main(string[] args)
        {
            Pessoa obj = new Pessoa();
            obj.apresentar();
            obj.apresentar("mariana");
            obj.apresentar("mari", 21);
        }
    }
}
