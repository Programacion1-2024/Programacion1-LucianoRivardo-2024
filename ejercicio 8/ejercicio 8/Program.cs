
Console.WriteLine("ingresar primer lado");
float lado1, lado2, lado3, perimetro;
if (!float.TryParse(Console.ReadLine(), out lado1))
{
    Console.WriteLine("dato incorrecto");
}
else
{
    Console.WriteLine("ingresar segundo lado");
    if (!float.TryParse(Console.ReadLine(), out lado2))
    {
        Console.WriteLine("segundo dato incorrecto");
    }
    else
    {
        Console.WriteLine("ingresar tercer lado");
        if (!float.TryParse(Console.ReadLine(), out lado3))
        {
            Console.WriteLine("tercer dato incorrecto");
        }
        else
        {
            perimetro = lado1 + lado2 + lado3;
            Console.WriteLine("el perimetro del triangulo es: " + perimetro);
        }
    }
}