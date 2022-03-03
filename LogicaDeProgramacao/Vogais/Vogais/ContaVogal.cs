using System;
using System.Collections.Generic;
using System.Text;

namespace Vogais
{
    class ContaVogal
    {
        
       public static char[] vogais = 
        {
            'a','e','i','o','u'
        };
        public static int CalcularVogais(string var)
        {
           int somaVogais = 0;
           char[] vetVar = var.ToLower().ToCharArray();//TRANSFORMA O UMA STRING EM UM VET DE CHAR
           for(int i = 0; i < vetVar.Length; i++)
            {
                for(int y = 0;y< vogais.Length; y++)
                {
                    if (vetVar[i].Equals(vogais[y]))//COMPARA O VALOR DE VetVar com vogais para saber se o caracter e uma vogal
                    {
                        somaVogais++;
                    }
                }
            }
            return somaVogais;
            
        }
        
    }
}
