using System;
using System.Globalization;

namespace CalculadoraFatorial
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("::::::::::::::::::::::::::::::::::::::::::::::::::::::::::");
                int entrada = int.Parse(Console.ReadLine());
                //Fatorial.CalcularFatorial(entrada) --> FUNÇÃO DA CLASSE Fatorial que FAZ O CALCULO USANDO UM INTEIRO COMO PARAMETRO DE ENTRADA   
                Console.WriteLine("Numero Fatorado:----->{0}", Fatorial.CalcularFatorial(entrada), CultureInfo.InvariantCulture);
                Console.WriteLine("::::::::::::::::::::::::::::::::::::::::::::::::::::::::::");
            }
            catch (Exception)
            {
                Console.WriteLine("Somente Numeros Interios");
            }
        }
    }
}
