using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalcularMedia
{
    public class Operacoes
    {
        public static List<Produto> listaProduto;

        public Operacoes()
        {
            listaProduto = new List<Produto>();
        }

        public void ImprimirLista()
        {
            foreach (Produto produto in listaProduto)
            {
                Console.WriteLine(produto.id + ": " + produto.nome + " " + produto.valor);
            }
        }

        public void InserirProduto(Produto produto)
        {
            listaProduto.Add(produto);
        }

        public void AtualizarProduto(Produto produto, string nome)
        {
            foreach (var item in listaProduto)
            {
                if (item.nome == nome)
                {
                    item.nome = produto.nome;
                    item.valor = produto.valor;
                }
            }
        }

        //public void DeletarProduto(string nome)
        //{
        //    for (int i = 0; i < listaProduto.Count; i++)
        //    {
        //        if (listaProduto[i].id == id)
        //        {
        //            listaProduto.RemoveAt(id);
        //        }
        //    }
        //}

        public void DeletarProduto(string nome)
        {

            foreach (var produto in listaProduto)
            {
                Console.WriteLine(produto);
                if (produto.nome == nome)
                {
                    listaProduto.Remove(produto);
                    break;
                }
            }
        }

        public void Media(Ano ano)
        {
            float Total_Valor = 0;
            int total_meses= 0;
            foreach (Mes m in ano.listadeMeses) //cada mes durante o ano
            {
                foreach (Produto p in m.listadeProdutos) //produto de cada mes
                {
                    Total_Valor += p.valor;
                }

                total_meses = ano.listadeMeses.Count;
            }

            float Media = Total_Valor / total_meses;
            Console.WriteLine(Media);
        }

        public void CalcularInvestimento(Ano ano)
        {
            float total_valor = 0;
            float investimento = 500;
            float media_investimento = 0;
            foreach (Mes m in ano.listadeMeses) //cada mes durante o ano
            {
                foreach (Produto p in m.listadeProdutos) //produto de cada mes
                {
                    total_valor += p.valor;
                }
                m.investimento = 500 -  total_valor;
                media_investimento += investimento;
                Console.WriteLine(m.investimento);
            }

            media_investimento = media_investimento / 12;
            Console.WriteLine(media_investimento);
        }
    }
}
