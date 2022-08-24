using System;

namespace CalcularMedia
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Produto p1 = new Produto();
            p1.id = 1;
            p1.nome = "arroz";
            p1.valor = 8;

            Produto p2 = new Produto();
            p2.id = 2;
            p2.nome = "feijao";
            p2.valor = 5;

            Produto p3 = new Produto();
            p3.id = 3;
            p3.nome = "carne";
            p3.valor = 50;

            Produto p4 = new Produto();
            p4.id = 4;
            p4.nome = "ovo";
            p4.valor = 12;

            Produto p5 = new Produto();
            p5.id = 4;
            p5.nome = "salada";
            p5.valor = 20;

            Mes mes_1 = new Mes();
            mes_1.nome = "Janeiro";
            mes_1.listadeProdutos.Add(p1);
            mes_1.listadeProdutos.Add(p2);
            mes_1.listadeProdutos.Add(p3);

            Mes mes_4 = new Mes();
            mes_4.nome = "Abril";
            mes_4.listadeProdutos.Add(p1);
            mes_4.listadeProdutos.Add(p2);
            mes_4.listadeProdutos.Add(p3);

            Mes mes_2 = new Mes();
            mes_2.nome = "Fevereiro";
            mes_2.listadeProdutos.Add(p2);
            mes_2.listadeProdutos.Add(p3);

            Mes mes_5 = new Mes();
            mes_5.nome = "Maio";
            mes_5.listadeProdutos.Add(p2);
            mes_5.listadeProdutos.Add(p3);

            Mes mes_3 = new Mes();
            mes_3.nome = "Marco";
            mes_3.listadeProdutos.Add(p4);

            Mes mes_6 = new Mes();
            mes_3.nome = "Junho";
            mes_3.listadeProdutos.Add(p4);


            Mes mes_7 = new Mes();
            mes_7.nome = "Julho";
            mes_7.listadeProdutos.Add(p1);
            mes_7.listadeProdutos.Add(p2);
            mes_7.listadeProdutos.Add(p4);
            mes_7.listadeProdutos.Add(p5);

            Mes mes_8 = new Mes();
            mes_8.nome = "Agosto";
            mes_8.listadeProdutos.Add(p1);
            mes_8.listadeProdutos.Add(p2);
            mes_8.listadeProdutos.Add(p4);
            mes_8.listadeProdutos.Add(p5);

            Mes mes_9 = new Mes();
            mes_9.nome = "Setembro";
            mes_9.listadeProdutos.Add(p1);
            mes_9.listadeProdutos.Add(p2);
            mes_9.listadeProdutos.Add(p4);
            mes_9.listadeProdutos.Add(p5);

            Mes mes_10 = new Mes();
            mes_10.nome = "Outubro";
            mes_10.listadeProdutos.Add(p1);
            mes_10.listadeProdutos.Add(p2);
            mes_10.listadeProdutos.Add(p3);
            mes_10.listadeProdutos.Add(p4);
            mes_10.listadeProdutos.Add(p5);

            Mes mes_11 = new Mes();
            mes_11.nome = "Novembro";
            mes_11.listadeProdutos.Add(p1);
            mes_11.listadeProdutos.Add(p2);
            mes_11.listadeProdutos.Add(p3);
            mes_11.listadeProdutos.Add(p4);
            mes_11.listadeProdutos.Add(p5);

            Mes mes_12 = new Mes();
            mes_12.nome = "Dezembro";
            mes_12.listadeProdutos.Add(p1);
            mes_12.listadeProdutos.Add(p2);
            mes_12.listadeProdutos.Add(p3);
            mes_12.listadeProdutos.Add(p4);
            mes_12.listadeProdutos.Add(p5);




            Ano ano = new Ano();
            ano.listadeMeses.Add(mes_1);
            ano.listadeMeses.Add(mes_2);
            ano.listadeMeses.Add(mes_3);
            ano.listadeMeses.Add(mes_4);
            ano.listadeMeses.Add(mes_5);
            ano.listadeMeses.Add(mes_6);
            ano.listadeMeses.Add(mes_7);
            ano.listadeMeses.Add(mes_8);
            ano.listadeMeses.Add(mes_9);
            ano.listadeMeses.Add(mes_10);
            ano.listadeMeses.Add(mes_11);
            ano.listadeMeses.Add(mes_12);

            //ano.listadeMeses.Add(mes_1);
            //ano.listadeMeses.Add(mes_2);


            //ano.ano = 2021;

            Operacoes op = new Operacoes();
            //op.Media(ano);
            //op.CalcularInvestimento(ano);

            for(; ; )
            {
                Console.WriteLine("Olá, seja bem vindo");
                Console.WriteLine("Digite o que deseja fazer");
                Console.WriteLine("1 - Atualizar os valores dos produtos");
                Console.WriteLine("2 - Adicionar um produto novo");
                Console.WriteLine("3 - Deletar um produto");
                Console.WriteLine("4 - Calcular a media anual"); 
                Console.WriteLine("6 - Ve o quanto investiu por ano");
                Console.WriteLine("7 - sair");

                short res = short.Parse(Console.ReadLine());

                switch (res)
                {
                    case 1:
                        {
                            Console.WriteLine("Digite o ");
                            break;
        
                        }
                        case 2:
                        {
                            Console.WriteLine("Digite o nome do produto que deseja adicionar");
                            string nome = Console.ReadLine();
                            Console.WriteLine("Digite o id do produto que deseja adicionar");
                            int id= int.Parse(Console.ReadLine());
                            Console.WriteLine("Digite o valor do produto que deseja adicionar");
                            float valor = float.Parse(Console.ReadLine());
                            Produto novo = new Produto();
                            novo.nome = nome;
                            novo.id = id;
                            novo.valor = valor;
                            op.InserirProduto(novo);
                            break;
                            }

                    case 3:
                        {
                            Console.WriteLine("Digite o nome do produto que deseja deletar");
                            string deletar = Console.ReadLine();
                            op.DeletarProduto(deletar);
                            break;
                        }
                    case 4:
                        {
                            op.Media(ano);
                            break;
                        }
                    case 5:
                        {
                            op.CalcularInvestimento(ano);
                            break;
                        }
                    case 6:
                        {
                            break;
                        }

                }
                }
                }

            }
        }
   
