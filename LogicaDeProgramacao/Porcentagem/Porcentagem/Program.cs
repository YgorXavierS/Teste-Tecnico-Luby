using System;
using System.Globalization;
namespace Porcentagem
{
    class Program
    {
        static void Main(string[] args)
        {
         
            Console.WriteLine("::::::::::::::::::::::::::::::::::::::::::::::::::::::");
            string formati;
            Console.WriteLine("Digite o valor ");
            string valorEntrada = Console.ReadLine();
            if (valorEntrada.Contains("R$"))
            {
                Console.WriteLine("");
                string porcentagem = Console.ReadLine();
                formati = Calc.CalcularDiferencaData(valorEntrada, porcentagem);
                Console.WriteLine(formati);
            }
            else
            {
                Console.WriteLine("Entrada de dado incorreta");
            }

            Console.WriteLine("::::::::::::::::::::::::::::::::::::::::::::::::::::::");
        }
    }
}
