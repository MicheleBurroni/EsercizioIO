using System;
using System.Collections.Generic;
using System.Text;

namespace Code
{
    class Output
    {
        public static void StampaNumero(int num)
        {
            Console.WriteLine($"Il numero intero è {num}");
        }
        public static void StampaNumero(double num)
        {
            Console.WriteLine($"Il numero decimale è {num}");
        }
        public static void StampaStringa(string stringa)
        {
            Console.WriteLine(stringa);
        }
    }
}
