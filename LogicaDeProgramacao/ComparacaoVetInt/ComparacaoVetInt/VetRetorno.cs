using System;
using System.Collections.Generic;
using System.Collections;
using System.Text;

namespace ComparacaoVetInt
{
    class VetRetorno
    {
        public static int[] ObterElementosFaltantes(int[] vet, int[]vet2)
        {
            ArrayList tempe = new ArrayList();
           
            for(int x = 0;x<vet.Length;x++)
            {
                bool ancora = false;
                for(int y = 0; y < vet2.Length; y++)
                {
                    if(vet[x] == vet2[y])
                    {
                        ancora = true;
                        break;
                    }
                }
                if (!ancora)
                {
                    tempe.Add(vet[x]);
                }
            }


            int[] ret= (int[])tempe.ToArray(typeof(int));

           

            return ret;
        }
    }
}
