// Ejercicio 4: Calcular promedio de notas utilizando una lista
//Consigna: El usuario debe ingresar 5 notas. El programa debe calcular el promedio de estas
//notas y mostrarlo en la consola. Utiliza una lista para almacenar las notas.

List <float> notas = new List<float> ();
float promedio = 0;
float resultado = 0;
for (int i = 1;i <= 5; i++)
{
    Console.WriteLine($"ingrese la nota n° {i}: ");
    if (!float.TryParse(Console.ReadLine(), out float nota))
    {
        Console.WriteLine("error ingrese un dato correcto");
    }
    else
    {
        notas.Add(nota);
    }
}
foreach (float nota in notas)
{
    promedio += nota;
    resultado = promedio / notas.Count;

}
Console.WriteLine("el promedio es: " + resultado);