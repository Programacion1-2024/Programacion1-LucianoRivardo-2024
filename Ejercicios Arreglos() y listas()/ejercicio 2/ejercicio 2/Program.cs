//Ejercicio 2: Calcular promedio de notas utilizando un arreglo
//Consigna: El usuario debe ingresar 5 notas. El programa debe calcular el promedio de estas
//notas y mostrarlo en la consola. Utiliza un arreglo para almacenar las notas.

int[] notas = new int[5];
float promedio = 0;
for (int i = 0; i < notas.Length; i++)
{
    Console.WriteLine($"ingrese la nota");
    if (!int.TryParse(Console.ReadLine(), out int nota))
    {
        Console.WriteLine("error dato incorrecto");
    }
    else
    {
        notas[i] = nota;
    }
}
for (int i = 0;i < notas.Length; i++)
{
    promedio += notas[i];
}
Console.WriteLine("el promedio de las notas es: " + (promedio/5));