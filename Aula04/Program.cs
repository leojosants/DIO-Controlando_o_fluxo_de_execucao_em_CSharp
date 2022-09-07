
Boolean condicao = true;
int valor;

do
{
    Console.Write("\nDigite um valor, 0 para sair: ");
    valor = int.Parse(Console.ReadLine());

    if (valor == 0)
    {
        Console.WriteLine("Você saiu da aplicação.");
        break;
    }
    else
    {
        Console.WriteLine($"Valor digitado: {valor}");
        continue;
    }

} while (condicao);

Console.Write("\n");