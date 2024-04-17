//El usuario ingresa un número N y se debe mostrar como resultado el factorial de dicho número.
int factorial = 1;
Console.WriteLine("ingrese un numero: ");
if (!int.TryParse(Console.ReadLine(), out int numero))
{
    Console.WriteLine("dato incorrecto, reintente");
}
else
{
    for (int i = 1; i <= numero; i++)
    {
            factorial *= i;
    }
}
Console.WriteLine($"el factorial de {numero} es: {factorial}");