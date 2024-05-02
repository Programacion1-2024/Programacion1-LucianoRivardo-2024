//Ejercicio 3: Ingresar datos en una lista y mostrarlos
//Consigna: El usuario debe ingresar 5 números enteros. El programa debe almacenar estos
//números en una lista y luego mostrarlos en la consola.

List<int> numeros = new List<int>();

for (int i = 0; i < 5; i++)
{
    Console.WriteLine("ingrese un numero: ");
    if (!int.TryParse(Console.ReadLine(), out int numero)) 
    {
        Console.WriteLine("dato incorrecto");
    }
    else
    {
        numeros.Add(numero);
    }
}
foreach (int numero in numeros)
{
    Console.WriteLine(numero);
}