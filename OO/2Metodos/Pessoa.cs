using System;

class Pessoa
{
    //meotodo função
    //pode criar metodo com o msm nome desde q os parametros sejam diferentes
    //método 1
    public void apresentar()
    {
        Console.WriteLine("olá!!");
    }

    //metodo 2
    public void apresentar(string nome)
    {
        Console.WriteLine("olá!!" +nome);
    }
    //metodo 3
    public void apresentar(string nome, int idade)
    {
        Console.WriteLine("olá!!" +nome+" voce tem " +idade+ " anos");
    }
}