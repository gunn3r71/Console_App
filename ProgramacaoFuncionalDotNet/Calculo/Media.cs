using System;
using System.Globalization;

namespace Calculo
{
    class Media
    {
        public static void CalcularMedia(double nota1, double nota2, double nota3)
        {
            #region Calcula e exibe média
            double media = (nota1 + nota2 + nota3) / 3;
            Console.WriteLine($"Media calculada: {media.ToString("F2", CultureInfo.InvariantCulture)}");
            #endregion
        }
    }
}
