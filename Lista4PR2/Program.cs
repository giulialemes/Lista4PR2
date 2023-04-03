using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista4PR2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Questões de programação

            //1- A afirmativa é verdadeira. É possivel atribuir uma variavel do tipo int para uma variavel do tipo float e vice-versa.

            //2- "Console.ReadLine()" lê uma linha inteira de caracteres do Console que é entrado pelo úsuario. E retorna uma string que retorna uma linha de de entrada completa.
            //   "Console.Read" lê um unico caracter de entrada do úsuario. E retorna um valor inteiro que representa o codigo do caracter lido.

            //3- Precsiamos ver se o valor que foi digitado pelo úsuario esta no formato certo para o tipo de variavel escolhida.

            //4- 

            //    int num, num2, num3;
            //    Console.WriteLine("Entre com um numero: ");
            //    num = int.Parse(Console.ReadLine());
            //    num2 = num / 2;
            //    num3 = num % 2;

            //    if (num3 == 0 && num2 * 2 > 10) 
            //    Console.WriteLine("Mensagem 1");


            //else
            //        Console.WriteLine("Mensagem 2 ");

            //    Console.ReadKey();

            //Esse programa serve para receber um número do usuário, dividir esse número por 2 e verificar se o resto da divisão é igual a zero.

            //5- 

            //float posinicial, posfinal, velmedia, tem;

            //Console.WriteLine("Digite a posição inicial: ");
            //posinicial = float.Parse(Console.ReadLine());

            //Console.WriteLine("Digite a velocidade média: ");
            //velmedia = float.Parse(Console.ReadLine());

            //Console.WriteLine("Digite o tempo: ");
            //tem = float.Parse(Console.ReadLine());  

            //posfinal = posinicial + (velmedia * tem);

            //Console.WriteLine("A posição final é: " + posfinal);
            //Console.ReadKey();

            //6 -
            {
                //int numero;

                //Console.WriteLine("Digite um numero: ");
                //numero = int.Parse(Console.ReadLine());

                //if (numero % 3 == 0 && numero % 5 == 0 && numero % 10 == 0)
                //{
                //    Console.WriteLine("O número é divisível por 3, 5 e 10.");
                //}

                //else if (numero % 3 == 0 && numero % 5 == 0)
                //{
                //    Console.WriteLine("O número é divisível por 3 e 5.");
                //}

                //else if (numero % 3 == 0 && numero % 5 != 0)
                //{
                //    Console.WriteLine("O número é somente divisível por 3.");
                //}

                //else if (numero % 3 == 0 && numero % 5 == 0)
                //{
                //    Console.WriteLine("O número é somente divisível por 5.");

                //    Console.ReadKey(); 

            }

            //7- não foi possivel ser feito, não consegui

            //8- 
            {
                double valorcompra, lucroliquido, imposlucro;
                int quantunidades;
                string marca;

                Console.WriteLine("Marcas de ração de gato:");
                Console.WriteLine("ROYAL\nWISKAS\nGOLDEN\nNUTRIEN\nSPECIALCAT\nMARBA\nGATUS");

                Console.Write("\nDigite a marca da ração de gato: ");
                marca = Console.ReadLine().ToUpper();

                Console.Write("Digite a quantidade de unidades: ");
                quantunidades = int.Parse(Console.ReadLine());

                switch (marca)
                {
                    case "ROYAL":
                        valorcompra = 129.50 * quantunidades;
                        lucroliquido = (129.50 - (77.5 / 100 * 129.50)) - (((129.50 - (77.5 / 100 * 129.50))) * (3 / 100));
                        break;
                    case "WISKAS":
                        valorcompra = 182.78 * quantunidades;
                        lucroliquido = (182.78 - (89.7 / 100 * 182.78)) - (((182.78 - (89.7 / 100 * 182.78))) * (7.5 / 100));
                        break;
                    case "GOLDEN":
                        valorcompra = 159.46 * quantunidades;
                        lucroliquido = (159.46 - (71.7 / 100 * 159.46)) - (((159.46 - (71.7 / 100 * 159.46))) * (22.5 / 100));
                        break;
                    case "NUTRIEN":
                        valorcompra = 144.80 * quantunidades;
                        lucro_liquido = (144.80 - (88.9 / 100 * 144.80)) - (((144.80 - (88.9 / 100 * 144.80))) * (25 / 100));
                        break;
                    case "SPECIALCAT":
                        valorcompra = 205.40 * quantunidades;
                        lucroliquido = (205.40 - (83.2 / 100 * 205.40)) - (((205.40 - (83.2 / 100 * 205.40))) * (22 / 100));
                        break;
                    case "MARBA":
                        valorcompra = 125.10 * quantunidades;
                        lucroliquido = (125.10 - (90.4 / 100 * 125.10)) - (((125.10 - (90.4 / 100 * 125.10))) * (17.9 / 100));
                        break;
                    case "GATUS":
                        valorcompra = 133.99 * quantunidades;
                        lucroliquido = (133.99 - (94.6 / 100 * 133.99)) - (((133.99 - (94.6 / 100 * 133.99))) * (20 / 100));
                        break;
                    default:
                        Console.WriteLine("Marca inválida.");
                        return;
                }

                imposlucro = (valorcompra - (quantunidades * (valorcompra / quantunidades))) - lucroliquido;

                Console.WriteLine("Valor total da compra: R$");

                Console.ReadKey());
        



       
            }

            









        }
    }
}
            

