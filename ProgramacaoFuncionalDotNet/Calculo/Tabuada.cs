using System;

namespace Calculo
{
    class Tabuada
    {
        public static void ExibeTabuada(int n)
        {
            #region Exibindo Tabuada
            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine($"{n} X {i} = {n * i}");
            }
            #endregion
        }
    }
}
