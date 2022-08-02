using System.Collections.Generic;
using System;

namespace Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();

            // var meuArray = new Teste[2];
            // meuArray[0] = new Teste();
            var meuArray = new int[5] { 1,2,3,4,5};
            meuArray[0] = 12;

            var funcionario = new Funcionario[5];
            foreach(var funcionario in funcionario)
                Console.WriteLine(funcionario.Id);

            // for(var item = 0; item < meuArray.Length; item++)
            // {
            //     Console.WriteLine(meuArray[item]);
            // }

            foreach(var item in meuArray)
                Console.WriteLine(item);
            

            // Console.WriteLine(meuArray[0]);
            // Console.WriteLine(meuArray[1]);
            // Console.WriteLine(meuArray[2]);
            // Console.WriteLine(meuArray[3]);
            // Console.WriteLine(meuArray[4]);

        }
    }

    public struct Funcionario
    {
        public int Id { get; set; }
        
        
    }

    // struct Teste{
    //     public int Id { get; set; }
    // }
}
