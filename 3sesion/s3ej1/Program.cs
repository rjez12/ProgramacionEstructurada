string entrada = string.Empty;
bool entradaValida = false;

while (!entradaValida)
{
    Console.WriteLine("Ingrese un número positivo: ");
    entrada = Console.ReadLine();

    if (int.TryParse(entrada, out int numero) && numero > 0)
    {
        entradaValida = true;
    }
    else
    {
        Console.WriteLine("Entrada Invalida. Intente de nuevo");
    }
}
Console.WriteLine($"Numero Ingresado: {entrada} (positivo)");
