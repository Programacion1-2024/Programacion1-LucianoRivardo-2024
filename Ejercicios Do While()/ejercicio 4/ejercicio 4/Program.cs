// Se le solicitará ingresar números al usuario, se repetirá el pedido hasta que ingrese
// un número mayor a 3 cifras. Mostrar la suma total de todos los ingresados antes del
// corte.

int numero;
int aux = 0;
do
{
    Console.WriteLine("ingrese un numero: ");
    if (int.TryParse(Console.ReadLine()?.Replace(".", ","), out numero))
    {
        if (numero < 100 && numero > -100)
        {
            aux += numero;
        }
    }
    else
    {
        Console.WriteLine("Dato incorrecto, intente otra vez");
    }
}
while (numero < 100 && numero > -100);
Console.WriteLine("la suma de los numeros ingresados es: " + (aux));