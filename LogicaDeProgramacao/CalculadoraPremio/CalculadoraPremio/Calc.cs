using System;
using System.Collections.Generic;
using System.Text;

namespace CalculadoraPremio
{
    class Calc
    {
        public static double CalcularPremio(int valor, string fatormultiplicacao, String descriminanteMulti)
        {
            if (descriminanteMulti != null)
            {
              
                double novoValorMUlti = double.Parse(descriminanteMulti);
                    if (novoValorMUlti <= 0)
                    {
                        return 0;
                    }
                    else
                    {
                        return valor * novoValorMUlti;
                    }
                }
             
            

            double ret =0;
            if (fatormultiplicacao == "basic")
            {
                 ret = (valor * 1.0);
            }
            else if (fatormultiplicacao == "vip")
            {
                ret = (valor * 1.2);
            }
            else if (fatormultiplicacao == "premium")
            {
                ret = (valor * 1.5);
            }
            else if (fatormultiplicacao == "deluxe")
            {
                ret = (valor * 1.8);
            }
            else if (fatormultiplicacao == "special")
            {
               ret = (valor * 2.0);
            }
            return ret;
        }
    }
}
