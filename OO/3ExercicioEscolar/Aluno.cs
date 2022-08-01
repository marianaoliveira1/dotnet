using System;

class Aluno
{
    //atributos
    public string nome;
    public double nota1, nota2;

    //media
    public  double Media()
    {
        double media;
        media = (nota1 + nota2)/2;

        return media;
    }
    //situacao
    public  string Situacao(double media)
    {
        if(media >= 7)
        {
            return "Aprovado";
        }
        else{
            return "Reprovado";
        }
    }
    //msg
    public void Mensagem() 
    {
        double obterMedia = Media();
        string obterSituacao = Situacao(obterMedia);
        Console.WriteLine("Nome: " +nome+ " está" +obterSituacao+" com a média " +obterMedia);
    }
}