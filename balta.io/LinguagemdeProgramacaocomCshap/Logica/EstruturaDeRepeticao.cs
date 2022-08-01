using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Logica
{
    public class EstruturaDeRepeticao
    {
        public void Estrutura()
        {
            /*
            if(conidcao) //caso seja verdadeira
            {

            }
            else //caso não sja
            {

            }
            */
            int idade = 18;
            int demaior = 21;
            if ( 25 == 32) { 
                Console.WriteLine("eh igual");
            }
            else if(25 != 32)
            {
                Console.WriteLine("eh diferente");
                if(idade > demaior) {
                    Console.WriteLine("de menor bb");
                }
                else 
                {
                     Console.WriteLine("de maior");
                }
            }
            
            else //senão
            {
                Console.WriteLine("oláaa");
            }
        }

        public void Muitasdecisao()
        {
            string valor = "joao";
            switch(valor)
            {
                case "andre": Console.WriteLine("o nome do menino nao eh andre"); break;
                case "marcelo": Console.WriteLine("o nome do meinno nao eh marcelo"); break;
                case "joao": Console.WriteLine("o nome do menino eh joão"); break;
                default: Console.WriteLine("não sei o nome dele"); break;
            }

        }

        public void Lacosderep()
        {
            for(int i =1; i <=5; i++)
            {
                Console.WriteLine(i);
            }

            int valor = 0;
            while(valor <= 5)
            {
                valor++;
                Console.WriteLine(valor);
            }

            do{
                Console.WriteLine(valor);
            } while(valor <= 5);
        }

    }
}