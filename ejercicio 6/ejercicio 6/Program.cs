Console.WriteLine("ingrese un numero: ");
float numero;
if (!float.TryParse(Console.ReadLine(), out numero))
{
    Console.WriteLine("dato incorrecto");
}
else
{
    if (numero > 0 ) 
    {
        Console.WriteLine("es positivo");

    }
    else
    {
        if (numero == 0)
        {
            Console.WriteLine("es cero");
        }
        else
        {
            Console.WriteLine("es negativo");
        }
        
    }

}
