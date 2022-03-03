using System;

namespace Vogais
{
    class Program
    {
        static void Main(string[] args)
        {
            string fraseEntrada = Console.ReadLine();
            Console.WriteLine(ContaVogal.CalcularVogais(fraseEntrada));
           
        }
    }
}
