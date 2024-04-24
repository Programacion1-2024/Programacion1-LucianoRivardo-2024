// Para el ingreso a un sistema se necesita solicitar nombre de usuario y clave, repetir
// este ingreso hasta que el usuario ingrese la clave correcta: 667788.

using System.Diagnostics.Contracts;

string usuario;
int contra;
do
{
    Console.WriteLine("ingrese nombre de usuario: ");
    usuario = Console.ReadLine();
    Console.WriteLine("ingrese la contraseña: ");
    if ((!int.TryParse(Console.ReadLine(), out contra)))
    {
        Console.WriteLine("contraseña incorrecta, intente otra vez.");
    }
    else
    {
        if (contra != 667788)
        {
            Console.WriteLine("contraseña incorrecta, intente otra vez.");
        }
    }
}
while (contra != 667788);
{
    Console.WriteLine("contraseña aceptada :) ");
}
