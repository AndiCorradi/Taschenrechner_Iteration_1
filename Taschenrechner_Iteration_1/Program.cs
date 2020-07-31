using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Taschenrechner_Iteration_1
{
    class Program
    {
        static void Main(string[] args)
        {
            // User Story "Addieren": Als Benutzer möchte ich zwei Zahlen mit Kommastellen eingeben, um deren Summe berechnen zu lassen.
            Console.Write("Bitte gib den ersten Summanden ein:");
            string ersterSummand = Console.ReadLine();
            Console.Write("Bitte gib den zweiten Summanden ein:");
            String zweiterSummand = Console.ReadLine();

            // Wandel Text in Gleitkommazahlen
            float ersterSummandAlsZahl = Convert.ToSingle(ersterSummand);
            float zweiterSummandAlsZahl = Convert.ToSingle(zweiterSummand);

            // Berechnung ausführen
            float summe = ersterSummandAlsZahl + zweiterSummandAlsZahl;

            // Ausgabe
            Console.WriteLine("Die Summe ist: {0}", summe);
            Console.WriteLine("Press AnyKey to close...");
            Console.ReadLine();

        }
    }
}
