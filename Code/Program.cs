using Code;
using System;

namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            string nome = Input.LeggiStringa("Inserisci nome");
            Output.StampaStringa("Inserisci età e peso");
            int età = Input.LeggiIntero();
            double peso = Input.LeggiDouble();

            Output.StampaStringa($"Mi chiamo {nome}, ho {età} anni e peso {peso}");
        }
    }
}
