using System;
using System.Collections.Generic;
using System.Text;

namespace CalculadoraPrimo
{
    class CalcNumeroPrimo
    {
        public static int  ContarNumerosPrimos(int numero)
        {
            int NumeroPrimo = 0;
            int Divisor = 0;
            
            for (int i = 2; i < numero; i++)
            {
                for (int y = numero; y > 0; y--)
                {
                    if (i % y == 0)
                    {
                        Divisor++;
                    }
                }
                if (Divisor > 2)
                {
                    NumeroPrimo++;
                    Divisor = 0;
                }
                else
                {
                    Divisor = 0;
                }
            }
            return (NumeroPrimo);

        }
    }
}
