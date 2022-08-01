using System;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Menu();
       }

       static void Menu() {
            Console.Clear();
            Console.WriteLine("opa meu patrao, seja bem vindo");
            Console.WriteLine("1 - Soma");
            Console.WriteLine("2 - subtracao");
            Console.WriteLine("3 - divisao");
            Console.WriteLine("4 - multiplicacao");
            Console.WriteLine("5 - sair");

            Console.WriteLine("------");
            Console.WriteLine("Selecione uma opcao");
            short res = short.Parse(Console.ReadLine());

            switch(res) 
            {
                case 1: 
                {
                    Soma();
                    break;
                }
                case 2: 
                {
                    Subtracao();
                    break;
                }
                case 3: 
                {
                    Divisao();
                    break;
                }
                case 4: 
                {
                    Multiplicacao();
                    break;
                }
                case 5: 
                {
                    System.Environment.Exit(0);
                    break;
                }
                default: {
                    Menu();
                    break;
                }
            }

       }

       static void Soma() {
            Console.Clear();
            Console.WriteLine("Primeiro valor: ");
            float v1 = float.Parse(Console.ReadLine());
            Console.WriteLine("Segundo valor: ");
            float v2 = float.Parse(Console.ReadLine());  

            Console.WriteLine("");

            float resultado = v1 + v2;
            Console.WriteLine($"Resultado da soma eh: {resultado} ");
            Console.ReadKey();
            Menu();
       }

       static void Subtracao() {

            Console.Clear();
            Console.WriteLine("Primeiro valor: ");
            float v1 = float.Parse(Console.ReadLine());
            Console.WriteLine("Segundo valor: ");
            float v2 = float.Parse(Console.ReadLine());  

            Console.WriteLine("");

            float resultado = v1 - v2;
            Console.WriteLine($"Resultado da subtracao eh: {resultado} ");
            Console.ReadKey();
            Menu();
       }

       
       static void Divisao() {
            Console.Clear();
            Console.WriteLine("Primeiro valor: ");
            float v1 = float.Parse(Console.ReadLine());
            Console.WriteLine("Segundo valor: ");
            float v2 = float.Parse(Console.ReadLine());  

            Console.WriteLine("");

            float resultado = v1 / v2;
            Console.WriteLine($"Resultado da divisao eh: {resultado} ");
            Console.ReadKey();
            Menu();
       }

        static void Multiplicacao() {
            Console.Clear();
            Console.WriteLine("Primeiro valor: ");
            float v1 = float.Parse(Console.ReadLine());
            Console.WriteLine("Segundo valor: ");
            float v2 = float.Parse(Console.ReadLine());  

            Console.WriteLine("");

            float resultado = v1 * v2;
            Console.WriteLine($"Resultado da multiplicacao eh: {resultado} ");
            Console.ReadKey();
            Menu();
       }
    }
}
