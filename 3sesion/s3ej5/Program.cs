int numero;

Console.WriteLine("Ingrese un numero positivo: ");
numero = int.Parse(Console.ReadLine());

int factorial = 1;
for (int i = 1; i <= numero; i++)
{
    factorial *= i;
}

Console.WriteLine($"El Factorial de {numero} es: {factorial}");
