using System;

namespace ComparacaoVetInt
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] vetor1 = new int[] { 1,2,4,5 };
            int[] vetor2 = new int[] {2,3,4,5 };


            if (vetor1.Length < vetor2.Length)
            {
                foreach (int i in VetRetorno.ObterElementosFaltantes(vetor2, vetor1))
                {
                    Console.WriteLine(i);
                }
            }else if (vetor1.Length > vetor2.Length){
                foreach (int i in VetRetorno.ObterElementosFaltantes(vetor1, vetor2))
                {
                    Console.WriteLine(i);
                }
            }
            else
            {
                foreach (int i in VetRetorno.ObterElementosFaltantes(vetor1, vetor2))
                {
                    Console.WriteLine(i);
                }
            }

            
            
        }
    }
}
