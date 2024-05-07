//List<string> palabras = new List<string>();
//string? palabra;
//do
//{
//    Console.WriteLine("ingrese una palabra");
//    palabra = Console.ReadLine();
//    if (!string.IsNullOrWhiteSpace(palabra))
//    {
//        palabras.Add(palabra);
//    } 
//}
//while (!string.IsNullOrWhiteSpace(palabra));
//palabras.Sort();
//foreach (string i in palabras)
//{
//    Console.WriteLine(i);
//}

//EJERCICIO 2

//float numero;
//List<float> numeros = new List<float>();
//do
//{
//    Console.WriteLine("ingrese un numero: ");
//    if (!float.TryParse(Console.ReadLine()?.Replace(",","."), out numero))
//    {
//        Console.WriteLine("error ingreso un dato incorrecto");
//    }
//    else
//    {
//        if (numero % 2 == 0)
//        {
//            numeros.Add(numero);
//        }
//    }
//}
//while (numero != 0);
//numeros.Sort();
//numeros.Reverse();
//foreach (int i in numeros)
//{
//    Console.Write($"{i} :");
//}

using Microsoft.VisualBasic;

float numero;
List <float> numerosFiltrados = new List<float>();
List<float> numeros = new List<float>();
do
{
    Console.WriteLine("ingrese un numero: ");
    if (!float.TryParse(Console.ReadLine()?.Replace(",", "."), out numero))
    {
        Console.WriteLine("error ingreso un dato incorrecto");
    }
    else if (numero != 0)
    {
        numeros.Add(numero);        
    }
}
while (numero != 0);
foreach (int i in numeros)
{
    if (i % 2 == 0)
    {
        numerosFiltrados.Add(i);
    }
}
numerosFiltrados.Sort();
numerosFiltrados.Reverse();
foreach (int i in numerosFiltrados)
{
    Console.Write($"{i} :");
}
