// El usuario ingresará una lista de nombre de persona, cuando se ingresé un nombre
// vacío, sin datos; el sistema informará cuántos nombres de han ingresado.

int i = 1;
int contador = 0;

while (i != 0)
{
    Console.WriteLine("ingrese el nombre: ");
    string nombre = Console.ReadLine();

    if (!int.TryParse(nombre, out int resultado)) //paso nombre a int para comprabar que solo se ingresen string.
    {
        if (string.IsNullOrEmpty(nombre)) //compruebo que nombre no sea null o que tenga al menos 1 caracter
        {
            i = 0;
        }
        else
        {
            contador++;
        }
    }
    else
    {
        i = 0;
    }
}
Console.WriteLine(contador);
