using System;
using System.Collections.Generic;
using System.Text;

namespace CalculadoraFatorial
{
    class Fatorial
    {
        public static int CalcularFatorial(int entrada)
        {
            int var = entrada;
            for (int i = var -1; i >=1; i--)
            {
                var = var * i;

            }
            return var;
        }
    }
}
