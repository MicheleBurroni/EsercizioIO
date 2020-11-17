using System;
using System.Collections.Generic;
using System.Text;

namespace Code
{
    public class Input
    {
        public static int LeggiIntero()
        {
            Console.WriteLine("Inserisci un numero intero ");
                int n = int.Parse(Console.ReadLine());
            return n;
        }
        public static double LeggiDouble()
        {
            Console.WriteLine("Inserisci un numero decimale ");
            double n = double.Parse(Console.ReadLine());
            return n;
        }
        public static string LeggiStringa(string v)
        {
            Console.WriteLine("Inserisci una stringa ");
            string s = (Console.ReadLine());
            return s;
        }
    }
}
