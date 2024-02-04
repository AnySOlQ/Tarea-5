using System;
using System.Collections.Generic;

class Programa
{
    static void Main()
    {
        List<int> miArreglo = new List<int> { 2, 7, 14, 23, 8, 11, 15, 2, 7, 11, 23, 15 };

        // Buscador números primos
        List<int> primos = AyudanteNumerosPrimos.ObtenerNumerosPrimos(miArreglo);
        Console.WriteLine("Números Primos: " + string.Join(" ", primos));

        // Buscador numeros que no se repiten
        List<int> noRepetidos = BuscadorNumerosUnicos.ObtenerNumerosUnicos(miArreglo);
        Console.WriteLine("Números que no se repiten: " + string.Join(" ", noRepetidos));

        // Buscador numeros repetidos
        List<int> masRepetidos = BuscadorNumerosMasRepetidos.ObtenerNumerosMasRepetidos(miArreglo);
        Console.WriteLine("Números que más se repiten: " + string.Join(" ", masRepetidos));
    }
}
