//Se necesita calcular el promedio de 8 números ingresados por el usuario.

Console.WriteLine("ingresar 8 numeros: ");

float suma = 0;
for (int i = 1; i <= 8; i++)
{
    Console.WriteLine($"ingresar valor n° {i}: ");
    if (!float.TryParse( Console.ReadLine(), out float numero))
    {
        Console.WriteLine("dato incorrecto");
        i--;
    }
    else
    {
        suma += numero;
    }

}
float resultado = (suma / 8);
Console.WriteLine($"el promedio es {resultado}");