using System;

class Aluno
{
    //atributos
    public string nome;
    public double nota1, nota2;

    //media
    public  double media()
    {
        double media;
        media = (nota1 + nota2)/2;

        return media;
    }
    //situacao
    public  string situacao(double media)
    {
        return media => 7 ? "Aprovado" : "reprovado";
    }
    //msg
    public void mensagem() 
    {
        double obterMedia = media();
        string obterSituacao = situacao(obterMedia);
        Console.WriteLine("Nome: " +nome+ " está" +obterSituacao+" com a média " +obterMedia);
    }
}