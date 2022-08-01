using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Logica
{
    public class Atribuicao
    {
        /*
        soma +
        subtracao -
        multiplicacao -
        divisao -

        x = 0 //atribuicao
        x += 5 // x = x + 5
        x -= 1 // x = x -1
        x *= 10 // x = x * 10
        x /= 2 // x = x / 2 

        igual ==
        diferente !=
        maior que >
        maior ou igual >=
        menro que <
        menor ou igual <<=

        int x = 25;
        x  == 0
        x != 0
        x > 0
        x >= 0
        x < 0
        x <= 0
        */

        // operador logico 
        // todas &&
        // só uma ||
        // negacao !

        public void Testando()
        {
            int x = 2;
            x = 2/2 + 2;

            int y = 2;
            y -= 72;

            int z = 2;
            z = 72 - 52;

            int a = 2;
            a = 75 * 52;

            int r = 5;
            r *= 5;

            Console.WriteLine(x);
            Console.WriteLine(y);
            Console.WriteLine(z);
            Console.WriteLine(a);
            Console.WriteLine(r);
        }
    }
}