// Siguiendo con el ejercicio anterior, al ingresar el positivo se mostrará el promedio de
// los números negativos ingresados.

int numero;
float negativos = 0;
int i = 0;
do
{
    Console.WriteLine("ingrese un numero: ");
    if (!int.TryParse(Console.ReadLine(), out numero))
    {
        Console.WriteLine("dato incorrecto, intente otra vez ");
        numero = -1;
    }
    else
    {
        if (numero < 0)
        {
            negativos += numero;
            i++;
        }
    }
}
while (numero < 0);
{
    Console.WriteLine("se ingreso un numero positivo :) ");
    Console.WriteLine("el promedio de los negativos es: " + (negativos / i));
}
