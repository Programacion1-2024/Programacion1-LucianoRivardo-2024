// Para calcular el consumo total de un cliente, el usuario primero ingresará cuántos
// productos compró; luego el sistema solicitará que ingrese el costo de cada uno de
// esos productos consumidos; al terminar informará el total adeudado por el cliente.
int cantidad;
int deuda = 0;
Console.WriteLine("ingrese cantidad de productos comprados: ");
if (!int.TryParse(Console.ReadLine(), out cantidad))
{
    Console.WriteLine("error ingrese un dato correcto.");
}
else
{
    while (cantidad != 0)
    {
        Console.WriteLine($"ingresar valor de producto n° {cantidad} ");
        if (!int.TryParse(Console.ReadLine(), out int valor))
        {
            Console.WriteLine("error ingrese un dato correcto.");
        }
        else
        {
            deuda += valor;
            cantidad--;
        }
    }
}
Console.WriteLine($"el total adeudado es: " + deuda);