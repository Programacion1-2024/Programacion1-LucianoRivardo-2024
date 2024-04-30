// Se ingresa el código de producto (son 10 productos, codificados del 1 al 10), luego el
// precio y la cantidad que hay del mismo. La carga finaliza cuando se ingresa un
// código = 0 ; al terminar indicar el código de producto que mayor cantidad tiene.
int aux = 0;
int codigo = -1;
int cantidad = 0;
int aux2 = 0;
while(codigo != 0)
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
        Console.WriteLine($"ingres un precio para el codigo n° {codigo}. ");
        if (!float.TryParse(Console.ReadLine(), out float precio))
        {
            Console.WriteLine("dato incorrecto intente otra vez");
        }
        else
        {
            Console.WriteLine($"ingrese la cantidad del producto n° {codigo}. ");
            if (!int.TryParse(Console.ReadLine(), out cantidad))
            {
                Console.WriteLine("dato incorrecto intente otra vez.");
            }
        }
    }
    if (aux < cantidad)
    {
        aux = cantidad;
        aux2 = codigo;
    }
}
Console.WriteLine($"el codigo n° {aux2} es el mas cantidad tiene.");