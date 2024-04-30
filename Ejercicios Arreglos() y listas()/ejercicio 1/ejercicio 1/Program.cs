//Ejercicio 1: Ingresar datos en un arreglo y mostrarlos
//Consigna: El usuario debe ingresar 5 números enteros. El programa debe almacenar estos
//números en un arreglo y luego mostrarlos en la consola.

int[] numeros = new int[5];

for  (int i = 0; i < numeros.Length; i++)
{
    Console.WriteLine("ingrese un numero: ");
    if (!int.TryParse(Console.ReadLine(), out int numero))
    {
        Console.WriteLine("error dato incorrecto"); 
    }
    else
    {
        numeros[i] = numero;
    }
}
for (int i = 0;i < numeros.Length; i++)
{
    Console.WriteLine($"el numero posicion {i} es: " + numeros[i]);
}