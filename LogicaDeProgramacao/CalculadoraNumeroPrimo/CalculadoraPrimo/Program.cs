using System;

namespace CalculadoraPrimo
{
    class Program
    {
        static void Main(string[] args)
        {
            int numero = int.Parse(Console.ReadLine());
            Console.WriteLine(CalcNumeroPrimo.ContarNumerosPrimos(numero));
           
        }
    }
}
