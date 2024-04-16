Console.WriteLine("Ingrese 5 valores enteros:");

int suma = 0;
for (int i = 1; i <= 5; i++)
{
    Console.Write($"Valor {i}: ");
    if (int.TryParse(Console.ReadLine(), out int numero))
    {
        suma += numero;
    }
    else
    {
        Console.WriteLine("Entrada inválida. Por favor ingrese un número válido.");
        i--; //resta para volver empezar el bucle en donde fallo.
    }
}
Console.WriteLine($"La suma de los 5 numeros es: {suma}");
