using System;
using System.Collections.Generic;
using System.Linq;

class BuscadorNumerosMasRepetidos
{
    public static List<int> ObtenerNumerosMasRepetidos(List<int> numeros)
    {
        var frecuencia = new Dictionary<int, int>();

        foreach (var num in numeros)
        {
            if (frecuencia.ContainsKey(num))
                frecuencia[num]++;
            else
                frecuencia[num] = 1;
        }

        int maxFrecuencia = frecuencia.Values.Max();

        return frecuencia.Where(par => par.Value == maxFrecuencia)
                        .Select(par => par.Key)
                        .ToList();
    }
}
