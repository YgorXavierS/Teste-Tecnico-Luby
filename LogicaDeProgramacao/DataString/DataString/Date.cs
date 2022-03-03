using System;
using System.Collections.Generic;
using System.Text;

namespace DataString
{
    class Date
    {
        public static int CalcularDiferencaData(String date1, String date2)
        {
            TimeSpan diferença;
            DateTime var1, var2;
            date1 = date1.Insert(2, "/").Insert(5, "/");
            date2 = date2.Insert(2, "/").Insert(5, "/");
            var1 = DateTime.Parse(date1);
            var2 = DateTime.Parse(date2);

            diferença = var1 - var2;
            

            return Math.Abs(diferença.Days);
        }
    }
}
