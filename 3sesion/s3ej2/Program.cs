Console.Write("Ingrese un número: ");
int numero = Convert.ToInt32(Console.ReadLine());

Console.WriteLine($"Tabla de Multiplicar del {numero}: ");
for (int i = 1; i <= 10; i++)
{
    Console.WriteLine($"{numero} * {i} = {numero * i}");
}

