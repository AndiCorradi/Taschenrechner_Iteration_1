using System;
using System.Collections.Generic;
using System.Data.Odbc;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Taschenrechner
{
    class Program
    {

        // METHODE DEFINIEREN (in 7 Schritten)
        // Modifizierer definieren
        // Datentyp des Rückgabewertes definieren
        // Methodennamen definieren
        // Rundeklammern an den Methodennamen anfügen
        // Überlegen welche Parameter benötigt werden (optional definieren)
        // Geschweifte Klammern einfügen
        // Methode implementieren (Anweisungen in den Methodenrumpf schreiben)

        

        static void Main(string[] args)
        {
            // User Story "Addieren": Als Benutzer möchte ich zwei Zahlen mit Kommastellen eingeben, um deren Summe berechnen zu lassen.
            // string Operation = HoleBenutzerEingabe("Bitte gib die gewünschte Operation ein: + oder -");
            string erstersteZahlAlsString = HoleBenutzerEingabe("Bitte gib die erste Zahl ein:");
            string zweiteZahlAlsString = HoleBenutzerEingabe("Bitte gib die zweite Zahl ein:");
            
            // Wandel Text in Gleitkommazahlen
            // TODO: Auslagern i Methode, wenn Struktur umfangreicher geworden ist.
            double ersteZahl = Convert.ToDouble(erstersteZahlAlsString);
            double zweiteZahl = Convert.ToDouble(zweiteZahlAlsString);

            // Berechnung ausführen
            double summe = Addiere(ersteZahl, zweiteZahl);

            // Ausgabe
            Console.WriteLine("Die Summe ist: {0}", summe);
            HoleBenutzerEingabe("Zum beenden bitte Return drücken !");
        }

        static double Addiere(double ersterSummand, double zweiterSummand)
        {
            double summe = ersterSummand + zweiterSummand;

            return summe;
        }

        static double Subtrahiere(double Minuend, double Subtrahend)
        {
            double Differenz = Minuend - Subtrahend;

            return Differenz;
        }

        static string HoleBenutzerEingabe(string ausgabeText)
        {
            Console.Write(ausgabeText);
            string Summand = Console.ReadLine();

            return Summand;
        }
    }
}
