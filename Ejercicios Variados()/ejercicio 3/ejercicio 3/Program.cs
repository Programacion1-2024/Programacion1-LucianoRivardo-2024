//Retomando el ejercicio anterior, a continuación se colocan los nombres para cada
//código de producto, (opcional si la carga se realiza del 1 al 10 sin pedir el código o si
//se ingresa el código y luego la descripción del mismo) ; al finalizar la carga de los 10
//códigos indicar el nombre de los productos que tuvieron un total de ventas menor a
//10 unidades.

using System.Diagnostics.CodeAnalysis;

int aux = 0;
int codigo = -1;
int cantidad = 0;
int stock;
string nombreProducto = "";
while (codigo != 0)
{

    Console.WriteLine("ingrese un codigo del 1 al 10. ");
    if (!int.TryParse(Console.ReadLine(), out codigo))
    {
        Console.WriteLine("dato incorrecto intente otra vez.");
    }
    else
    {
        if (codigo == 0)
        {
            break;
        }

        Console.WriteLine($"ingrese el stock del producto {codigo}.");
        if (!int.TryParse(Console.ReadLine(), out stock))
        {
            Console.WriteLine("dato incorrecto intente otra vez");
        }
        else
        {
            Console.WriteLine($"ingres un precio para el codigo n° {codigo}. ");
            if (!float.TryParse(Console.ReadLine()?.Replace(",", "."), out float precio))
            {
                Console.WriteLine("dato incorrecto intente otra vez");
            }
            else
            {
                Console.WriteLine($"ingrese el nombre del producto n° {codigo}");
                nombreProducto = Console.ReadLine();
                Console.WriteLine($"ingrese la cantidad de ventas del producto n° {codigo}. ");
                if (!int.TryParse(Console.ReadLine(), out cantidad))
                {
                    Console.WriteLine("dato incorrecto intente otra vez.");
                }
                else
                {
                    if (cantidad <= 10)
                    {
                        aux = cantidad;
                    }
                }
            }
        }
    }
}
if (aux <= 10)
{
    Console.WriteLine($"el porducto {nombreProducto}, tuvo menos de 10 ventas");
}