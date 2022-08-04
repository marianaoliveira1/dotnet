using System;

namespace Exceptions
{
    class Program
    {
        static void Main(string[] args)
        {
            var arr = new int[3];

            try
            {
                // for(var index =0; index <10; index++)
                //     Console.WriteLine(arr[index]);
                Salvar("bburucutuguruguduakstiguiriguidô");
            }
            catch(IndexOutOfRangeException ex) //fora do index
            {
                Console.WriteLine(ex.InnerException);
                Console.WriteLine(ex.Message);
                Console.WriteLine("nao esconterei o indice princesa");
            }
            catch(ArgumentNullException ex) //erro ao salvar o arquivo
            {
                Console.WriteLine(ex.InnerException);
                Console.WriteLine(ex.Message);
                Console.WriteLine("falha ao cadatrar gatinha");
            }
            catch (MinhaException ex)
            {
                Console.WriteLine(ex.InnerException);
                Console.WriteLine(ex.Message);
                Console.WriteLine(ex.QuandoAconteceu);
                Console.WriteLine("exceção customizadahh");
            }
            catch (Exception ex) //sempre por ultimo
            {
                Console.WriteLine(ex.InnerException);
                Console.WriteLine(ex.Message);
                Console.WriteLine("opa deu erro bb");
            }
            finally
            {
                Console.WriteLine("macho o fim chegou");
            }

            
        }

        private static void Salvar(string texto)
        {
            if(string.IsNullOrEmpty(texto)){
                throw new MinhaException(DateTime.Now);
            }
        }

        public class MinhaException : Exception
        {
            public MinhaException(DateTime date)
            {
                QuandoAconteceu = date;
            }

            public DateTime QuandoAconteceu { get; set;}
        }
        
    }
}
