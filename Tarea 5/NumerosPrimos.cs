using System;
using System.Collections.Generic;
using System.Linq;

class AyudanteNumerosPrimos
{
    public static List<int> ObtenerNumerosPrimos(List<int> numeros)
    {
        return numeros.Where(num => EsPrimo(num)).ToList();
    }

    private static bool EsPrimo(int numero)
    {
        if (numero < 2)
            return false;

        for (int i = 2; i <= Math.Sqrt(numero); i++)
        {
            if (numero % i == 0)
                return false;
        }

        return true;
    }
}
