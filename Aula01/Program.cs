
using System;

namespace Aula01
{

    class Program
    {
        static void Main(string[] args)
        {
            int valor1;
            int valor2;
            int total;

            Console.Write("\nDigite o primeiro valor: ");
            valor1 = int.Parse(Console.ReadLine());

            Console.Write("Digite o segundo valor: ");
            valor2 = int.Parse(Console.ReadLine());

            total = valor1 + valor2;

            Console.WriteLine($"\nPrimeiro valor digitado foi: {valor1}");
            Console.WriteLine($"O segundo valor digitado foi: {valor2}");
            Console.WriteLine($"A soma dos valores {valor1} e {valor2} é: {total}");

            Console.Write("\n");
        }

    } // fim class Program

} // fim namespace Aula01