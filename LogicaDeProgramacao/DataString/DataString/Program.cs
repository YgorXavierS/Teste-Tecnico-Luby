using System;
namespace DataString

{
    class Program
    {
        static void Main(string[] args)
        {
            String Date1, Date2;

            Date1 = Console.ReadLine();
            Date2 = Console.ReadLine();
            if(Date1.Length > 8 && Date2.Length > 8)
            {
                Console.WriteLine("Entrada de dados incorreta");
            }
            else
            {
                Console.WriteLine(Date.CalcularDiferencaData(Date1, Date2));
            }
;        }
    }
}
