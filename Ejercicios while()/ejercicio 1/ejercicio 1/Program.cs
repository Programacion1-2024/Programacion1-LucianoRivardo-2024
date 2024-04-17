// El usuario ingresará valores positivos, cuando no tenga más valores ingresará 0
// (cero).El sistema deberá informar la suma de los ingresados.


Console.WriteLine("ingresar un valor");
if (!float.TryParse(Console.ReadLine().Replace(".",","), out float valor))
{
    Console.WriteLine("valor incorrecto");
}
else
{
    float total = valor;
    while (valor != 0)
    {
        Console.WriteLine("ingresar un valor");
        if (float.TryParse(Console.ReadLine().Replace(".",","), out float numero))
        {
            if (numero == 0)
            {
                valor = 0;
            }
            else
            {
                total = total + numero;
                
            }
        }
        else
        {
            Console.WriteLine("valor incorrecto");
        }
    }
    Console.WriteLine(total);
}
