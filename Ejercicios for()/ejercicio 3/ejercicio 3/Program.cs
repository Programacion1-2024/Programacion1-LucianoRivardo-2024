/*Para calcular el total de una factura, el usuario ingresará pares de datos Costo
unitario y cantidad comprada; de unas 5 compras; Informar el total adeudado.*/


float total = 0;
for (int i = 1; i <= 5; i++)
{
    Console.Write($"ingresar costo de unidad n° {i}: ");
    if (!float.TryParse(Console.ReadLine(), out float numero))
    {
        Console.WriteLine("Dato invalido, reintente otra vez: ");
        i--;
    }
    else
    {
        total += numero;
    }
    Console.Write($"ingresar cantidad comprada de unidad n° {i}: ");
    if (!float.TryParse(Console.ReadLine(), out float numero2))
    {
        Console.WriteLine("Dato invalido, reintente otra vez: ");
        i--;
    }
    else
    {
        total = total * numero2;
    }
}
Console.WriteLine($"el total adeudado es de {total} pesos. ");