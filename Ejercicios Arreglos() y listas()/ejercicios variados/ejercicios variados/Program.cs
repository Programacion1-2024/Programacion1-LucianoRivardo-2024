List<int> codigos = new List<int>();
List<float> precios = new List<float>();
List<int> cantidades = new List<int>();
int codigo = 0;
float precio;
int cantidad;
int masCantidad;
int indice = 0;
do
{
    Console.WriteLine("Ingresar codigo de producto: ");
    if (!int.TryParse(Console.ReadLine(), out codigo))
    {
        Console.WriteLine("error ingrese un valor correcto.");
    }
    else
    {
        if (codigo == 0)
        {
            break;
        }
        else
        {
            codigos.Add(codigo);
            Console.WriteLine($"ingrese precio del producto n° {codigo} : ");
            if (!float.TryParse(Console.ReadLine()?.Replace(",","."), out precio))
            {
                Console.WriteLine("error ingrese un valor correcto.");
            }
            else
            {
                precios.Add(precio);
                Console.WriteLine($"ingres cantidad del producto n° {codigo}");
                if (!int.TryParse(Console.ReadLine(), out cantidad))
                {
                    Console.WriteLine("error ingrese un valor correcto.");
                }
                else
                {
                    cantidades.Add(cantidad);
                }
            }
        }
        masCantidad = cantidades.Max();
        indice = cantidades.IndexOf(masCantidad);        
    }
}
while (codigo != 0);
Console.WriteLine($"el codigo con mas cantidad es el n°: {codigos[indice]}");