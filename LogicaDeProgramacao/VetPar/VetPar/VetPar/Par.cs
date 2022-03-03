using System;
using System.Collections.Generic;
using System.Collections;
using System.Text;

namespace VetPar
{
    class Par
    {
        public static int[] ObterElementosPares(int[] vet)
        {
            int tamanhoVetorSaida = 0;
            ArrayList par = new ArrayList();

            for (int x = 0; x < vet.Length; x++)//DESCOBRE O TAMANHO DO VETOR PARES
            {
                if (vet[x] % 2 == 0)
                {
                    par.Add(vet[x]);
                    tamanhoVetorSaida++;                  
                }

               
            }

            int[] ret = (int[]) par.ToArray(typeof(int));
            
            return ret ;
        }
    }
}