using System;

class Pessoa
{
    public double peso, altura;

    public double IMC()
    {
        return peso/(altura*altura);
    }

    public string situacao(double imc) {
        string retorno;

        if(imc < 18.5)
        {
            retorno ="e você esta abaixo do peso";
        }
        else if(imc < 25)
        {
            retorno ="e você esta com o peso normal";
        }
        else if(imc < 30)
        {
            retorno ="e você esta acima do peso";
        }
        else if(imc < 35)
        {
            retorno ="e você esta com obesidade I";
        }
        else if(imc < 35)
        {
            retorno ="e você esta com obesidade II";
        }
        else 
        {
            retorno ="e você esta com obesidade III";
        }

        return retorno;
    }

    public void mensagem()
    {
        double obertIMC = IMC();
        string obterSituacao = situacao(obertIMC);
        Console.WriteLine("seu imc eh: " +obertIMC);
        Console.WriteLine("e sua situacao eh:  " +obterSituacao);
    }
}