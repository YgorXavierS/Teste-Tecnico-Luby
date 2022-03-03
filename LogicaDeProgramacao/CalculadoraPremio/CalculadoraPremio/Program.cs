using System;
using System.Globalization;
namespace CalculadoraPremio
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine(":::::::::::::::::::::::::::::::::::::::::::::::::::::");
                Console.WriteLine("Digite o valor do prêmio");
                int valor = int.Parse(Console.ReadLine());
                if (valor <= 0)
                {
                    Console.WriteLine("Valor digitado não aceito");
                    while (valor <= 0)
                    {
                        Console.WriteLine("Digite o valor novamente");
                        valor = int.Parse(Console.ReadLine());

                    }
                }

                Console.WriteLine("Tipo: 'basic' fator multiplicação do prêmio: 1 \n " +
                                  "Tipo: 'vip' fator multiplicação do prêmio: 1.2 \n" +
                                  "Tipo: 'premium' fator multiplicação do prêmio: 1.5\n " +
                                  "Tipo: 'deluxe' fator multiplicação do prêmio: 1.8\n " +
                                  "Tipo: 'special' fator multiplicação do prêmio: 2\n " +
                                "");

                String fatorMulti = Console.ReadLine().ToLower();
                Console.WriteLine("Deseja Fator de MultiPlicação Especial S/N");
                char PickMultiEspecial = char.Parse(Console.ReadLine().ToLower());


                if (PickMultiEspecial == 's')
                {
                    Console.WriteLine("Digite o novo fator de Multiplicação");
                    String multi = Console.ReadLine();
                    Console.WriteLine("O valor do Prêmio é de:{0:F2}", Calc.CalcularPremio(valor, fatorMulti, multi), CultureInfo.InvariantCulture);
                }

                else if (PickMultiEspecial == 'n')
                {
                    Console.WriteLine("O valor do Premio E de:{0:F2}", Calc.CalcularPremio(valor, fatorMulti, null), CultureInfo.InvariantCulture);
                }
            }
            catch (Exception ex)
            {
                if(ex is FormatException || ex is StackOverflowException)
                {
                    Console.WriteLine("Verifique os dados inseridos");
                }
            }
        }
    }
}
