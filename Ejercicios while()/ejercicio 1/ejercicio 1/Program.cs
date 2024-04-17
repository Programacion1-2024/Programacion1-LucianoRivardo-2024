// El usuario ingresará valores positivos, cuando no tenga más valores ingresará 0
// (cero).El sistema deberá informar la suma de los ingresados.

float valor;
Console.WriteLine("ingresar un valor");
if (!float.TryParse(Console.ReadLine().Replace(".",","), out valor))
{
    Console.WriteLine("valor incorrecto");
}
else
{
    float total = valor;
    while (valor != 0)
    {
        Console.WriteLine("ingresar un valor");
        if (float.TryParse(Console.ReadLine().Replace(".",","), out valor))
        {
            total = total + valor;
        }
        else
        {
            Console.WriteLine("valor incorrecto");
        }
    }
    Console.WriteLine("la suma de todos los datos ingresados es: " + total);
}
