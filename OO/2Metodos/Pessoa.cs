using System;

class Pessoa
{
    //meotodo função
    //pode criar metodo com o msm nome desde q os parametros sejam diferentes
    //método 1
    public void Apresentar()
    {
        Console.WriteLine("olá!!");
    }

    //metodo 2
    public void Apresentar(string nome)
    {
        Console.WriteLine("olá!!" +nome);
    }
    //metodo 3
    public void Apresentar(string nome, int idade)
    {
        Console.WriteLine("olá!!" +nome+" voce tem " +idade+ " anos");
    }
}