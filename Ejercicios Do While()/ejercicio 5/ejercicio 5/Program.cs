// Siguiendo con el ejercicio anterior, al ingresar uno mayor a 3 cifras se mostrará el
// promedio de los ingresados.

float numero;
float aux = 0;
int i = 0;
do
{
    Console.WriteLine("ingrese un numero: ");
    if (float.TryParse(Console.ReadLine()?.Replace(".", ","), out numero))
    {
        if (numero < 100 && numero > -100)
        {
            aux += numero;
            i++;
        }
    }
    else
    {
        Console.WriteLine("Dato incorrecto, intente otra vez");
    }
}
while (numero < 100 && numero > -100);
Console.WriteLine("el promedio de los numeros ingresados es: " + (aux/i));