//De una lista de 8 números indicar cual es el mayor.


Console.Write($"ingresar valor n° 1: ");
if (!float.TryParse(Console.ReadLine(), out float aux))
{
    Console.WriteLine("dato invalido, intentelo otra vez. ");
}
else
{
    for (int i = 2; i <= 8; i++)
    {
        Console.Write($"ingresar valor n° {i}: ");
        if (!float.TryParse(Console.ReadLine(), out float numero))
        {
            Console.WriteLine("dato invalido, intentelo otra vez. ");
            i--;
        }
        else
        {

            if (numero > aux)
            {
                aux = numero;
            }
        }
    }
}

Console.WriteLine($"el numero mayor es: {aux}");