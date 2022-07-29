using System;

namespace Teste
{
    public class Program
    {
        static void Main(string[] args)
        {
           int idade; //certo
            //int idade = 25;
            //var idade = 25;
            // var idade;  ERRADO

            const int IDADE_MINIMA = 0;
            // const int IDADE_MINIMA; ERRADO PQ TEM Q TER VALOR
            // const var IDADE_MINIMA; ERRADO
            // const var IDADE_MINIMA = 0; ERRADO

            /* 
                byte: representa um byte de fato - 8-bits: 0 até 255
                sbyte: valor negativo: -8-bits: -128 até 127
            */
            byte  meuByte = 127;

            /*
            Número inteiors
                short: número pequenos
                int: números razoavies
                long: números grandes
                ulong = só numeros positivos
            */

            int idadee = 25;
            uint vida = 25;
            short meu = 25;
            long sei = 25;

            /*
            NÚMEROS REAIS
                -> número que tem ponto, casa decimal 
                float = coloca o f no final
                double = entende q é um número com virgula
                decimal = coloca o m no final
            */

            float salario = 2.500f;
            decimal salarioanual = 12.000m;
            double salariomes = 52.8920;

            /*
                boolean = true ou false
            */

            bool dia = true;

            /*
            CHAR
            um único palavra, único caractere
            aspa simples
            */
            char primeiraLeta = 'a';

            /*
                STRING:
                    -> uma lista de char, um conjunto
            
            */
            string umastring = "String";

            /*
            VAR
            subtitui o nome de um tipo
            */

            var leite = "Leite";
            var idadeAdulta = 53;

            //OBJECT -> msm coisa do var

            object demosntracao = "sim";
            object crianca = 12;

            // comentario um alinha

            /* 
                comentario em 
                varias linhas
            */

            /// notação xml (metadata) 

            //void -> vazio, retorno de metodo
            //null -> vazio, nullo, defnição de tipo
            // n pode passar p int p é nubolo
            int ?nulo = null;
            Console.WriteLine(nulo);
            int ?nulo1 = 25;
            Console.WriteLine(nulo);
            int inteiro = int.Parse("100");
            int inteiro2 = Convert.ToInt32("100");

            int inteiro3 = 100;
            float real = 25.5f;

            // real = inteiro3;
            // inteiro = (int)real;
            // string valorReal = real.ToString();
            // inteiro3 = int.Parse(real.ToString());
            // inteiro = Convert.ToInt32(real);

            // Console.WriteLine(valorReal);
            Console.WriteLine(inteiro);

        }
    }
}

