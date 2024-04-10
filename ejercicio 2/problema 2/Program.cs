using System.ComponentModel.Design;
using System.Drawing;

Console.WriteLine("Ingrese un numero:");

string entrada = Console.ReadLine();

if (int.TryParse(entrada, out int numero)) //se convierte el string en int y se almacena en "numero"
{
    
    if (numero % 2 == 0)
    {
        Console.WriteLine("El numero ingresado es par.");
    }
    else
    {
        Console.WriteLine("El numero ingresado es impar.");
    }
}
else
{
    Console.WriteLine("No se ingreso un numero valido.");
}