using System;
class Aluno
{
    //atributos
    private double nota1, nota2;
    //metodo
    private double Media()
    {
        return (nota1+nota2)/2;
    }

    public void Mensagem()
    {
        Console.WriteLine("Informe a priemira nota");
        nota1 = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Informe a segunda nota");
        nota2 = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("a média eh: " +Media());
    }
}