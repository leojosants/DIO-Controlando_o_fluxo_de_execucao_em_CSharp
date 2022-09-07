
// EXEMPLO 1
/*
Boolean condicao = true;
int valor;

Console.Write("\n");
while (condicao)
{
    Console.Write("Digite qualquer valor, ZERO para sair: ");
    valor = int.Parse(Console.ReadLine());

    if (valor == 0)
    {
        Console.WriteLine("O valor ZERO foi digitado, saindo da aplicação...");
        condicao = false;
        break;
    }
    else
    {
        Console.WriteLine($"Valor digitado: {valor}\n");
    }
}

Console.Write("\n");
*/


// EXEMPLO 2
/*
Boolean condicao2 = true;
int valor2;

do
{
    Console.Write("Digite qualquer valor, ZERO para sair: ");
    valor2 = int.Parse(Console.ReadLine());

    if (valor2 == 0)
    {
        Console.WriteLine("O valor ZERO foi digitado, saindo da aplicação...");
        condicao2 = false;
    }
    else
    {
        Console.WriteLine($"Valor digitado: {valor2}\n");
    }
} while (condicao2);

Console.Write("\n");
*/


// EXEMPLO 3
/*
Console.Write("\n");

int valor3;

Console.Write("Digite um valor: ");
valor3 = int.Parse(Console.ReadLine());

for (int i = valor3; i <= 10; i++)
{
    Console.WriteLine(i);
}

Console.Write("\n");
*/

// EXEMPLO 4
int[] lista = {1, 2, 3, 4, 5};

foreach (int num in lista)
{
    Console.WriteLine(num);
}