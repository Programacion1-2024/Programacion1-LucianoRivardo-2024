
Console.WriteLine("Ingrese un numero:");

string entrada = Console.ReadLine();


if (float.TryParse(entrada, out float numero))
{
    float resultado = numero * numero;
    Console.WriteLine("el area es " + resultado);
}
else
{
    Console.WriteLine("dato incorrecto, ingrese un numero");
}