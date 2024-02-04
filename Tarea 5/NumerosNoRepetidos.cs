using System;
using System.Collections.Generic;
using System.Linq;

class BuscadorNumerosUnicos
{
    public static List<int> ObtenerNumerosUnicos(List<int> numeros)
    {
        return numeros.GroupBy(num => num)
                      .Where(group => group.Count() == 1)
                      .Select(group => group.Key)
                      .ToList();
    }
}
