using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Isograma
{
    /*
        Consigna: 
            Determina si una palabra o frase es un isograma.

            Un isograma (también conocido como "palabra sin patrón") es una palabra o frase sin una letra repetida; sin embargo, se permite que aparezcan espacios y guiones varias veces.

            Ejemplos de isogramas:

            lumberjacks
            background
            downstream
            six-year-old

            La palabra isogramas, sin embargo, no es un isograma porque la s se repite.

            TIPS: Funciones ToCharArray, IndexOf y LastIndexOf de la clase String
    */

    public static class Isogram
    {
        public static bool IsIsogram(string word)
        {
            char[] caracteres = word.ToLower().ToCharArray();

            for (int i = 0; i < caracteres.Length; i++)
            {
                char caracterActual = caracteres[i];

                if (caracterActual != ' ' && caracterActual != '-')
                {
                    for (int j = i + 1; j < caracteres.Length; j++)
                    {
                        char caracterSiguiente = caracteres[j];

                        if (caracterActual == caracterSiguiente)
                        {
                            return false;
                        }
                    }
                }
            }
            return true;
        }
    }
}