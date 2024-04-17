// Siguiendo el ejercicio anterior, calcular el promedio de los valores ingresados.
int i = 0;
float valor;
Console.WriteLine("ingresar un valor");
if (!float.TryParse(Console.ReadLine().Replace(".", ","), out valor))
{
    Console.WriteLine("valor incorrecto");
}
else
{
    float total = valor;
    while (valor != 0)
    {
        
        Console.WriteLine("ingresar un valor");
        if (float.TryParse(Console.ReadLine().Replace(".", ","), out valor))
        {
            total = total + valor;
            i++;
        }
        else
        {
            Console.WriteLine("valor incorrecto");
        }
    }
    Console.WriteLine("el promedio de los datos ingresados es: " + (total/i));
}

