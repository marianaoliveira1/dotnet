using System;

namespace _2Metodos
{
    class Program
    {
        static void Main(string[] args)
        {
            Pessoa obj = new Pessoa();
            obj.Apresentar();
            obj.Apresentar("mariana");
            obj.Apresentar("mari", 21);
        }
    }
}
