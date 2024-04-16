using System;
using static System.Runtime.InteropServices.JavaScript.JSType;

Console.WriteLine("ingresar numero: ");
float entrada1, entrada2;
if(!float.TryParse(Console.ReadLine(), out entrada1))
{
    Console.WriteLine("dato incorrecto");
}
else
{
    Console.WriteLine("ingresar segundo numero: ");
    if (!float.TryParse(Console.ReadLine(), out entrada2))
    {
        Console.WriteLine("segundo dato incorrecto");
    }
    else
    {
        if (entrada1 > entrada2)
        {
            Console.WriteLine(entrada1 + " es mayor que " + entrada2);
        }
        else
        {
            Console.WriteLine(entrada2 + " es mayor que " + entrada1);
        }
    }
}   
