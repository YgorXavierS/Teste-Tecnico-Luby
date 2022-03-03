using System;
using System.Collections.Generic;
using System.Collections;
using System.Text;

namespace BuscaElementoString
{
    class Pesquisa
    {
        public static string[] BuscarPessoa(string[] nomes, string elementoNome)
        {
            ArrayList nomeArray = new ArrayList();

            for (int i = 0; i < nomes.Length; i++)
            {
                if (nomes[i].Contains(elementoNome))
                {
                    nomeArray.Add(nomes[i]);
                }
            }

            string[] ret = (string[])nomeArray.ToArray(typeof(string));

            return ret;

        }
    }
}
