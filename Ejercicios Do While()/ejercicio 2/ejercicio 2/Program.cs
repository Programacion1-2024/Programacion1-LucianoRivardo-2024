// Se le solicitará ingresar un número al usuario, se repetirá el pedido hasta que
// ingrese un positivo.

int numero = -1;
do
{
    Console.WriteLine("ingrese un numero: ");
    if (!int.TryParse(Console.ReadLine(), out numero))
    {
        Console.WriteLine("dato incorrecto, intente otra vez ");
        //numero = -1;
    }
}
while (numero <= 0);
{
    Console.WriteLine("se ingreso un numero positivo :) ");
}
