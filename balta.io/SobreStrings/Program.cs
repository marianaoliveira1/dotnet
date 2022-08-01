using System;

namespace SobreStrings
{
    class Program
    {
        static void Main(string[] args)
        {
            //id => identificar um item
            var id = Guid.NewGuid();
            id.ToString();

            id = new Guid();
            
            Console.WriteLine(id.ToString().Substring(0,8));
        }
    }
}
