// Para calcular el total de una factura, el usuario ingresará pares de datos Costo
// unitario y cantidad comprada; cuando se ingrese costo 0 finaliza el ingreso de datos;
// informar el total adeudado.
float cantidadAdeudada = 0;
float costoUnitario = 0;
int i = 1;
float totalDeuda = 0;
while (i != 0)
{
    Console.WriteLine("ingresar costo unitario o un 0 en caso de finalizar: ");
    if (float.TryParse(Console.ReadLine(), out float valor))
    {
        costoUnitario = valor;
        if (valor == 0)
        {
            i = 0;
        }
        else
        {
            Console.WriteLine("ingresar cantidad comprada: ");
            if (float.TryParse(Console.ReadLine(), out float valor1))
            {
                cantidadAdeudada = costoUnitario * valor1;
                totalDeuda += cantidadAdeudada;

            }
            else
            {
                Console.WriteLine("error, dato incorrecto intente otra vez.");
            }
        }
    }
    else
    {
        Console.WriteLine("error, dato incorrecto intente otra vez.");
    }
    
}
Console.WriteLine(totalDeuda);