﻿using System;
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
            // User Story "Addieren": Als Benutzer möchte ich zwei Zahlen mit Kommastellen eingeben, um deren Summe oder Differenz oder Quotient oder Produkt berechnen zu lassen.
            string Operation = HoleBenutzerEingabe("Bitte gib die gewünschte Operation ein (+ - * /): ");
            string erstersteZahlAlsString = HoleBenutzerEingabe("Bitte gib die erste Zahl ein: ");
            string zweiteZahlAlsString = HoleBenutzerEingabe("Bitte gib die zweite Zahl ein: ");
            
            // Wandel Text in Gleitkommazahlen
            // TODO: Auslagern in Methode, wenn Struktur umfangreicher geworden ist.
            double ersteZahl = Convert.ToDouble(erstersteZahlAlsString);
            double zweiteZahl = Convert.ToDouble(zweiteZahlAlsString);

            // Berechnung ausführen
            Berechnung(ersteZahl, zweiteZahl, Operation);

            // Ausgabe
            double Resultat = Berechnung(ersteZahl, zweiteZahl, Operation);
            GibResultatAus(Resultat, Operation); 
            HoleBenutzerEingabe("Zum beenden bitte Return drücken !");
        }

        static double Addiere(double ersterSummand, double zweiterSummand)
        {
            double Resultat = ersterSummand + zweiterSummand;

            return Resultat;
        }

        static double Subtrahiere(double Minuend, double Subtrahend)
        {
            double Resultat = Minuend - Subtrahend;

            return Resultat;
        }

        static double Multipliziere(double Multiplikator, double Multiplikand)
        {
            double Resultat = Multiplikator * Multiplikand;

            return Resultat;
        }

        static double Dividiere(double Dividend, double Divisior)
        {
            double Resultat = Dividend / Divisior;

            return Resultat;
        }

        static string HoleBenutzerEingabe(string ausgabeText)
        {
            Console.Write(ausgabeText);
            string Zahl = Console.ReadLine();

            return Zahl;
        }

        static double Berechnung(double ersteZahl, double zweiteZahl, string Operation)
        {
            double Resultat = 0;
            switch (Operation)
            {
                case "+":
                    Resultat = Addiere(ersteZahl, zweiteZahl);
                    break;

                case "-":
                    Resultat = Subtrahiere(ersteZahl, zweiteZahl);
                    break;

                case "/":
                    Resultat = Dividiere(ersteZahl, zweiteZahl);
                    break;

                case "*":
                    Resultat = Multipliziere(ersteZahl, zweiteZahl);
                    break;

                default:
                    break;
            }
            return Resultat;
        }

        static void GibResultatAus(double Resultat, String Operation)
        {
            switch (Operation)
            {
                case "+":
                    Console.WriteLine("Die Summe ist: {0}", Resultat);
                    break;

                case "-":
                    Console.WriteLine("Die Differenz ist: {0}", Resultat);
                    break;

                case "/":
                    Console.WriteLine("Der Quotione ist: {0}", Resultat);
                    break;

                case "*":
                    Console.WriteLine("Das Produkt ist: {0}", Resultat);
                    break;

                default:
                    Console.WriteLine("Du hast eine ungültige Operation eingegeben");
                    break;
            }
        }
     
    }
}
