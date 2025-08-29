Console.Write("Ingrese una frase: ");
string frase = Console.ReadLine().ToLower();
int Contadorvocales = 0;

foreach (char c in frase)
{
    if (c == 'a' || c == 'e' || c == 'i' || c == 'o' || c == 'u')
    {
        Contadorvocales++;
    }
}
Console.WriteLine($"La frase tiene {Contadorvocales} vocales");

