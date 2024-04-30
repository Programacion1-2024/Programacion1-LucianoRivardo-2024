//Retomando el ejercicio 1 ; al finalizar la carga de productos, se ingresan las ventas
//que hubo por cada código, puede haber más de 1 venta por cada articulo. El ingreso
//finaliza al colocar un código en 0. Informar al final los que tienen una cantidad (o
//sea la cantidad inicial , restando las ventas que tuvo) menor o igual a 0.

int aux = 0;
int codigo = -1;
int cantidad = 0;
int aux2 = 0;
int stock;
float rest = 0;
float aux3 = 0;
while (codigo != 0)
{

    Console.WriteLine("ingrese un codigo del 1 al 10. ");
    if (!int.TryParse(Console.ReadLine(), out codigo))
    {
        Console.WriteLine("dato incorrecto intente otra vez.");
    }
    else
    {
        if (codigo == 0)
        {
            break;
        }

        Console.WriteLine($"ingrese el stock del producto {codigo}.");
        if (!int.TryParse(Console.ReadLine(),out stock))
        {
            Console.WriteLine("dato incorrecto intente otra vez");
        }
        else
        {
            Console.WriteLine($"ingres un precio para el codigo n° {codigo}. ");
            if (!float.TryParse(Console.ReadLine()?.Replace(",", "."), out float precio))
            {
                Console.WriteLine("dato incorrecto intente otra vez");
            }
            else
            {
                Console.WriteLine($"ingrese la cantidad de ventas del producto n° {codigo}. ");
                if (!int.TryParse(Console.ReadLine(), out cantidad))
                {
                    Console.WriteLine("dato incorrecto intente otra vez.");
                }
                else
                {
                    rest = stock - cantidad;

                }
            }
        
        }
    }
    if (rest <= 0)
    {
        aux3 = rest;
        Console.WriteLine($"el codigo {aux2} tiene la siguiente cantidad de stock: {aux3}.");
    }
    else
    {
        Console.WriteLine("queda stock del producto");
    }
    if (aux < cantidad)
    {
        aux = cantidad;
        aux2 = codigo;      
    }
 
   
}
