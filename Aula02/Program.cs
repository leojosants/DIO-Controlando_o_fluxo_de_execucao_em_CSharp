using System;

namespace Aula02
{

    class Program
    {

        static void Main(string[] args)
        {
            // EXEMPLO 2
            
            int mes;

            Console.Write("\nDigite um número do mês [1 a 12]: ");
            mes = int.Parse(Console.ReadLine());

            if (mes < 1 || mes > 12)
            {
                Console.WriteLine($"O número {mes} não correspende à nenhum mês.");
            }
            else
            {
                if (mes == 1)
                {
                    Console.WriteLine($"O número {mes} corresponde ao mês de JANEIRO.");
                }
                else if (mes == 2)
                {
                    Console.WriteLine($"O número {mes} corresponde ao mês de FEVEREIRO.");
                }
                else if (mes == 3)
                {
                    Console.WriteLine($"O número {mes} corresponde ao mês de MARÇO.");
                }
                else if (mes == 4)
                {
                    Console.WriteLine($"O número {mes} corresponde ao mês de ABRIL.");
                }
                else if (mes == 5)
                {
                    Console.WriteLine($"O número {mes} corresponde ao mês de MAIO.");
                }
                else if (mes == 6)
                {
                    Console.WriteLine($"O número {mes} corresponde ao mês de JUNHO.");
                }
                else if (mes == 7)
                {
                    Console.WriteLine($"O número {mes} corresponde ao mês de JULHO.");
                }
                else if (mes == 8)
                {
                    Console.WriteLine($"O número {mes} corresponde ao mês de AGOSTO.");
                }
                else if (mes == 9)
                {
                    Console.WriteLine($"O número {mes} corresponde ao mês de SETEMBRO.");
                }
                else if (mes == 10)
                {
                    Console.WriteLine($"O número {mes} corresponde ao mês de OUTUBRO.");
                }
                else if (mes == 11)
                {
                    Console.WriteLine($"O número {mes} corresponde ao mês de NOVEMBRO.");
                }
                else
                {
                    Console.WriteLine($"O número {mes} corresponde ao mês de DEZEMBRO.");
                }
            }

            // MELHORANDO A LÓGICA
            
            int numMes;

            Console.Write("\nDigite um número do mês [1 a 12]: ");
            numMes = int.Parse(Console.ReadLine());

            switch (numMes)
            {
                case 1:
                    Console.WriteLine($"O número {numMes} corresponde ao mês de JANEIRO.");
                    break;

                case 2:
                    Console.WriteLine($"O número {numMes} corresponde ao mês de FEVEREIRO.");
                    break;

                case 3:
                    Console.WriteLine($"O número {numMes} corresponde ao mês de MARÇO.");
                    break;

                case 4:
                    Console.WriteLine($"O número {numMes} corresponde ao mês de ABRIL.");
                    break;

                case 5:
                    Console.WriteLine($"O número {numMes} corresponde ao mês de MAIO.");
                    break;

                case 6:
                    Console.WriteLine($"O número {numMes} corresponde ao mês de JUNHO.");
                    break;

                case 7:
                    Console.WriteLine($"O número {numMes} corresponde ao mês de JULHO.");
                    break;

                case 8:
                    Console.WriteLine($"O número {numMes} corresponde ao mês de AGOSTO.");
                    break;

                case 9:
                    Console.WriteLine($"O número {numMes} corresponde ao mês de SETEMBRO.");
                    break;

                case 10:
                    Console.WriteLine($"O número {numMes} corresponde ao mês de OUTUBRO.");
                    break;

                case 11:
                    Console.WriteLine($"O número {numMes} corresponde ao mês de NOVEMBRO.");
                    break;

                case 12:
                    Console.WriteLine($"O número {numMes} corresponde ao mês de DEZEMBRO.");
                    break;
                
                default:
                    Console.WriteLine($"O número {numMes} não correspende à nenhum mês.");
                    break;
            }

            // EXEMPLO 1
            /* 
            int idade;

            Console.Write("\nInforme sua idade: ");
            idade = int.Parse(Console.ReadLine());

            if (idade >= 18)
            {
                Console.WriteLine("Você é maior de idade.");
            }
            else
            {
                Console.WriteLine("Você é menor de idade.");
            }
            */

            Console.Write("\n");
        }

    } // fim class 

} // fim namespace Aula02