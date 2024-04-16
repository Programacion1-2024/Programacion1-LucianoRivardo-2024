// El usuario ingresa 5 pares de valores con el nombre del cliente y el total gastado,
// indicar el cliente que gastó más.
float maximoGasto = 0;
string clienteMasGasto = "";
float gastado = 0;
for (int i = 0; i < 4; i++)
{
    Console.WriteLine("ingresar nombre cliente: ");
    string nombre = Console.ReadLine();

    Console.WriteLine("ingresar total gastado: ");
    if (float.TryParse(Console.ReadLine(),out float valor))
    {
        gastado = valor;
    }
    else
    {
        Console.WriteLine("dato incorrecto intente otra vez: ");
        i--;

    }
    if (gastado > maximoGasto)
    {
        maximoGasto = gastado;
        clienteMasGasto = nombre;
    }   

}
Console.WriteLine($"el cliente que mas gasto es:  {clienteMasGasto} ");   
    
    
