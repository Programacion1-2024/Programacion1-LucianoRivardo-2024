//EJERCICIO 1
//List<int> codigos = new List<int>();
//List<float> precios = new List<float>();
//List<int> cantidades = new List<int>();
//int codigo = 0;
//float precio;
//int cantidad;
//int masCantidad;
//int indice = 0;
//do
//{
//    Console.WriteLine("Ingresar codigo de producto: ");
//    if (!int.TryParse(Console.ReadLine(), out codigo))
//    {
//        Console.WriteLine("error ingrese un valor correcto.");
//    }
//    else
//    {
//        if (codigo == 0)
//        {
//            break;
//        }
//        else
//        {
//            codigos.Add(codigo);
//            Console.WriteLine($"ingrese precio del producto n° {codigo} : ");
//            if (!float.TryParse(Console.ReadLine()?.Replace(",","."), out precio))
//            {
//                Console.WriteLine("error ingrese un valor correcto.");
//            }
//            else
//            {
//                precios.Add(precio);
//                Console.WriteLine($"ingres cantidad del producto n° {codigo}");
//                if (!int.TryParse(Console.ReadLine(), out cantidad))
//                {
//                    Console.WriteLine("error ingrese un valor correcto.");
//                }
//                else
//                {
//                    cantidades.Add(cantidad);
//                }
//            }
//        }
//        masCantidad = cantidades.Max();
//        indice = cantidades.IndexOf(masCantidad);        
//    }
//}
//while (codigo != 0);
//Console.WriteLine($"el codigo con mas cantidad es el n°: {codigos[indice]}");

//EJERCICIO 2

//List<int> codigos = new List<int>();
//List<float> precios = new List<float>();
//List<int> cantidades = new List<int>();
//List<int> ventas = new List<int>();
//List<int> menores = new List<int>();
//int codigo = 0;
//float precio;
//int cantidad;
//int masCantidad;
//int indice = 0;
//int venta;
//do
//{
//    Console.WriteLine("Ingresar codigo de producto: ");
//    if (!int.TryParse(Console.ReadLine(), out codigo))
//    {
//        Console.WriteLine("error ingrese un valor correcto.");
//    }
//    else
//    {
//        if (codigo == 0)
//        {
//            break;
//        }
//        else
//        {
//            codigos.Add(codigo);
//            Console.WriteLine($"ingrese precio del producto n° {codigo} : ");
//            if (!float.TryParse(Console.ReadLine()?.Replace(",", "."), out precio))
//            {
//                Console.WriteLine("error ingrese un valor correcto.");
//            }
//            else
//            {
//                precios.Add(precio);
//                Console.WriteLine($"ingres cantidad del producto n° {codigo}");
//                if (!int.TryParse(Console.ReadLine(), out cantidad))
//                {
//                    Console.WriteLine("error ingrese un valor correcto.");
//                }
//                else
//                {
//                    cantidades.Add(cantidad);
//                    Console.WriteLine($"ingrese las ventas del producto n° {codigo}");
//                    if (!int.TryParse(Console.ReadLine(), out venta))
//                    {
//                        Console.WriteLine("Error ingrese un dato correcto");
//                    }
//                    else
//                    {
//                        ventas.Add(venta);
//                    }
//                }
//            }
//        }
        

//    }
//    foreach (int i in cantidades)
//    {
//        foreach (int j in ventas)
//        {
//            float resta = i - j;
//            if (resta <= 0)
//            {
//                indice = cantidades.IndexOf(j);
//                menores.Add(indice);
//            }

//        }
//    }
//}
//while (codigo != 0);
////Console.WriteLine($"el codigo con mas cantidad es el n°: {codigos[indice]}");
//foreach (int i in menores)
//{
//    Console.WriteLine($"el producto n° {i} es menor o igual a 0");
//}
