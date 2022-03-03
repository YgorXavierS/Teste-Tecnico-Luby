using System;

namespace VetPar
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite o tamanho do arrey");
            int tamanhoArrey = int.Parse(Console.ReadLine());
            int[] Vet = new int[tamanhoArrey];
            for (int i = 0; i < tamanhoArrey; i++)
            {
                int entrada = int.Parse(Console.ReadLine());
                Vet[i] = entrada;
            }

            for(int i = 0; i< Par.ObterElementosPares(Vet).Length; i++)//PERCORRE O VETOR DE PARES
                {
                    Console.WriteLine("{0\n}",Par.ObterElementosPares(Vet)[i]);
                }

            }
    }
}
