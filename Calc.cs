using System;
using System.Globalization;

namespace csharpguiadoprogramador
{
    public static class Calc
    {
        
        public static void Somar(double n1, double n2)
        {
            double resultado = n1 + n2;
            Console.Write(resultado.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}