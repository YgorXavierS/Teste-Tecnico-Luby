using System;

namespace BuscaElementoString
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] vetor = new string[]
            {
                "John Doe",
                "Jane Doe",
                "Alice Jones",
                "Bobby Louis",
                "Lisa Romero"
            };

            string pesquisa = Console.ReadLine();

            for (int x = 0; x < Pesquisa.BuscarPessoa(vetor,pesquisa).Length; x++){
                Console.WriteLine(Pesquisa.BuscarPessoa(vetor,pesquisa)[x]);
            }
 
        }
    }
}
