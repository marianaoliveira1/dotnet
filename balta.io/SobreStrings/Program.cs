using System.Globalization;
using System;
using System.Text;
using System.Text.RegularExpressions;

namespace SobreStrings
{
    class Program
    {
        static void Main(string[] args)
        {
            //id => identificar um item
            // var id = Guid.NewGuid();
            // id.ToString();

            // id = new Guid();
            
            // Console.WriteLine(id.ToString().Substring(0,8));

            //interpolacao -> juntar string com outros valores
            // var price = 10.2 + 9;
            // var texto = "o preco do produto eh " + price + " apenas na promocao";
            // var ideia = string.Format("O preco do produto eh {0} apenas na promocao {1}", price, price);
            // var text = $@"o preco do produto
            //  eh {price} apenas na promocao";

            // Console.WriteLine(texto);
            // Console.WriteLine(ideia);
            // Console.WriteLine(text);

             //comprar texto

            // var text = "teste do teste";
            // Console.WriteLine(text.CompareTo("testando"));
            // Console.WriteLine(text.CompareTo("Testando")); //ve se ta ok
            // Console.WriteLine(text.Contains("teste")); //ve se tem uma palavra
            // Console.WriteLine(text.Contains("teste", StringComparison.OrdinalIgnoreCase)); //ve se tem uma palavra, msm sendo com maiuscula e minuscula

             //var text = "teste do teste";
            // Console.WriteLine(text.StartsWith("teste")); //o testo comeca com a palavra tal
            // Console.WriteLine(text.EndsWith("teste")); //o testo termina com a palavra tal

            // Console.WriteLine(text.Equals("teste do teste")); //ve se eh igual

            //indice -> indica uma posicao


            // var text = "teste do teste";
            // Console.WriteLine(text.IndexOf("do")); //passar o msm tipo
            // Console.WriteLine(text.LastIndexOf("s")); //o ultimo

            // var text = "Teste do tEste";
            // Console.WriteLine(text.ToLower()); //tudo mainusculo
            // Console.WriteLine(text.ToUpper()); //tud maiusculo
            // Console.WriteLine(text.Insert(5, "AQUI")); //tud maiusculo
            // Console.WriteLine(text.Remove(2, 2)); //remove
            //lenght -> quantidade

            // var texto = "Este é um texto de teste";
            // Console.WriteLine(texto.Replace("Este", "Isto")); //este por isto, troca
            // Console.WriteLine(texto.Replace("texto", "exemplo"));

            // var texto = "Este é um texto, de teste";
            // var divisao = texto.Split(','); //duvide em linhas
            // Console.WriteLine(divisao[0]); //vai quebrando
            // Console.WriteLine(divisao[1]);

            //  var texto = "Este é um texto de teste";
            // Console.WriteLine(texto.Substring(0, 5)); pega um caractere
            // Console.WriteLine(texto.Substring(texto.LastIndexOf(" ") + 1, 5));
            // var texto = "Este é           um texto de teste";
            // Console.WriteLine(texto.Trim());

            // texto = "  Este é um texto de teste        ";
            // Console.WriteLine(texto.Trim());

            // var texto = new StringBuilder();
            // texto.Append("Este");
            // texto.Append("é");
            // texto.Append("um");
            // texto.Append(Environment.NewLine);
            // texto.Append("texto");
            // Console.WriteLine(texto.ToString());
        }
    }
}
