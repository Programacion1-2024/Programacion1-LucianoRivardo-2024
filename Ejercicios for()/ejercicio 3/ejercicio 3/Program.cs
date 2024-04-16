/*Para calcular el total de una factura, el usuario ingresará pares de datos Costo
unitario y cantidad comprada; de unas 5 compras; Informar el total adeudado.*/


float total = 0;
int bucle = 0;
Console.WriteLine("ingresar cantidad comprada de un producto: ");
if (!int.TryParse(Console.ReadLine(), out int numero2))
{
    Console.WriteLine("Dato invalido, reintente otra vez: ");
}
else
{
    bucle += numero2;
}
    
for (int i = 1; i <= bucle; i++)
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
}
Console.WriteLine($"el total adeudado es de {total} pesos. ");