using System;
using System.Collections.Generic;
using System.Text;
using System.Globalization;
namespace Porcentagem 
{
    class Calc
    {
        public static string CalcularDiferencaData(string entrada,string porcentagem)
        {
          
        
            String[] ValorEntrada = entrada.Split(" ");
            int termino = porcentagem.IndexOf("%");
            porcentagem = porcentagem.Remove(termino);//RETIRA O % DA PORCENTAGEM
            double Descondo = double.Parse(porcentagem)/100;

            // double valor =(double.Parse(ValorEntrada[1]));
            double valor = (double.Parse(ValorEntrada[1]));
            double RetFinal = (valor - (valor * Descondo));

            String AddFormt ="R$ " + RetFinal.ToString().Insert(1,".");

            return AddFormt; 
        }
    }
}
