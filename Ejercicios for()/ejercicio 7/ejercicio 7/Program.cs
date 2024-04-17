// El usuario ingresa un número entero positivo N
// y se deben mostrar todos los números enteros positivos pares desde 0 (incluido) hasta N

Console.WriteLine("ingresar un numero: ");
if (!int.TryParse(Console.ReadLine(), out int value))
{
    Console.WriteLine("dato invalido intente otra vez");
}
else
{
    for (int i = 0; i <= value;i+=2) //i suma de a 2 numeros y siempre sera par
    {
            Console.WriteLine(i);
    }
}