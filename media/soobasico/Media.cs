using System;

namespace soobasico
{
    public class Media
    {
        int arroz = 8;
        int feijao = 5;
        int carne = 50;
        int ovo = 12;
        int salada = 20;

        public double Janeiro() 
        {
            double valor = arroz + feijao + carne;
            return valor;
        }
        public double Fevereiro() 
        {
            double valor = feijao + carne;
            return valor;
        }
        public double Marco() 
        {
            double valor = ovo;
            return valor;
        }

        public double Abril() 
        {
            double valor = arroz + feijao + carne;
            return valor;
        }

        public double Maio() 
        {
            double valor = feijao + carne;
            return valor;
        }

        public double Junho() 
        {
            double valor = ovo;
            return valor;
        }

        public double Julho() 
        {
            double valor = arroz + feijao + salada + ovo;
            return valor;
        }

        public double Agosto() 
        {
            double valor = arroz + feijao + salada + ovo;
            return valor;
        }

        public double Setembro() 
        {
            double valor = arroz + feijao + salada + ovo;
            return valor;
        }

        public double Outubro() 
        {
            double valor = arroz + feijao + salada + ovo + carne;
            return valor;
        }
        
        public double Novembro() 
        {
            double valor = arroz + feijao + salada + ovo + carne;
            return valor;
        }

        public double Dezembro() 
        {
            double valor = arroz + feijao + salada + ovo + carne;
            return valor;
        }

        public void CalculoDaMedia()
        {
            double obeterMedia;

            obeterMedia = Janeiro() + Fevereiro() + Marco() + Abril() + Maio() + Junho() + Julho() + Agosto() + Setembro() + Outubro() + Novembro() + Dezembro();
            obeterMedia /=12;
            Console.WriteLine($"o valor da media eh: {obeterMedia}");
        
        }
    }
}



/*
    ter um menu
    poder setar os valores dos produtos
    poder atualizar os valores dos produtos
    poder adicionar um produto novo
    poder deletar um produto novo
    calcular a média anual de gasto
    ver o mês que mais teve gasto
    
*/