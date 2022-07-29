using System;

namespace Logica
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Olá, mundo");
            MeuMetodo();
            Retornanome("Mari", "oliveira");
        }

        static void MeuMetodo()
        {
            Console.WriteLine("c# eh legal");
        }

        static string Retornanome(string nome, string sobrenome, int idade = 21)
        {
            // if(55 ==55)
            //     return "";

            return nome + " " + sobrenome + " tem" + idade.ToString();
        }
    }
}
