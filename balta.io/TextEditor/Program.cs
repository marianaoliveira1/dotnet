using System;
using System.IO;
using System.Threading;

namespace TextEditor
{
    class Program
    {
        static void Main(string[] args)
        {
            Menu();
        }

        static void Menu()
        {
            Console.Clear();
            Console.WriteLine("O que vicê deseja fazer?");
            Console.WriteLine("1 - abrir arquivo");
            Console.WriteLine("2 -  criar um novo arquivo");
            Console.WriteLine("0 - sair ");
            short option = short.Parse(Console.ReadLine());

            switch(option)
            {
                case 0: System.Environment.Exit(0); break;
                case 1: Abrir(); break;
                case 2: Editar(); break;
            }

        }

        static void Abrir() {
            Console.Clear();
            Console.WriteLine("Qual o caminho do arquivo?");

            string path = Console.ReadLine();

            using (var file = new StreamReader(path))
            {
                string text = file.ReadToEnd();
                Console.WriteLine(text);
            }

            Console.WriteLine("");
            Console.ReadLine();
            Menu();
        }
        static void Editar() {
            Console.Clear();
            Console.WriteLine("Digite seu texto abaixo (ESC para sair");
            Console.WriteLine("--------");
            string text = "";

            do
            {
                text += Console.ReadLine();
                text += Environment.NewLine;

            } while (ConsoleKey.Escape != Console.ReadKey().Key);

        Salvar(text);
            
        }

        static void Salvar(string text)
        {
            Console.Clear();
            Console.WriteLine("Qual caminho para salvar o arquivo?");
            var path =  Console.ReadLine();

            using (var file = new StreamWriter(path))
            {
                file.Write(text);
            }

            Console.WriteLine($"Arquivo salvo {path} com sucesso!");
            Thread.Sleep(2000);

            Menu();
        }
    }
}
