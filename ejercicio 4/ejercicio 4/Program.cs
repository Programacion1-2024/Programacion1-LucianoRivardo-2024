Console.Write("Ingrese el primer numero: ");
float numero1, numero2, numero3, promedio;
if (!float.TryParse(Console.ReadLine(), out numero1))
{
    Console.WriteLine("dato incorrecto");
}
else
{
    Console.Write("Ingrese el segundo numero: ");
    if (!float.TryParse(Console.ReadLine(), out numero2))
    {
        Console.WriteLine("dato incorrecto");
    }
    else
    {
        Console.Write("Ingrese el tercer numero: ");
        if (!float.TryParse(Console.ReadLine(), out numero3))
        {
            Console.WriteLine("dato incorrecto");
        }
        else
        {
            promedio = (numero1 + numero2 + numero3) / 3;
            Console.WriteLine("El promedio entre los tres numeros ingresados es: " + promedio);
        }
    }
}