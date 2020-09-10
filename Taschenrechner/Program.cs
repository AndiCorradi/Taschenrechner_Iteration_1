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
            // User Story "Addieren": Als Benutzer möchte ich zwei Zahlen mit Kommastellen eingeben, um deren Summe oder Differenz oder Quotient oder Produkt berechnen zu lassen.
            string Operation = HoleBenutzerEingabe("Bitte gib die gewünschte Operation ein (+ - * /): ");
            string erstersteZahlAlsString = HoleBenutzerEingabe("Bitte gib die erste Zahl ein: ");
            string zweiteZahlAlsString = HoleBenutzerEingabe("Bitte gib die zweite Zahl ein: ");
            
            // Wandel Text in Gleitkommazahlen
            // TODO: Auslagern in Methode, wenn Struktur umfangreicher geworden ist.
            double ersteZahl = Convert.ToDouble(erstersteZahlAlsString);
            double zweiteZahl = Convert.ToDouble(zweiteZahlAlsString);

            // Berechnung ausführen
            RechnerModel model = new RechnerModel();
            model.Berechne(ersteZahl, zweiteZahl, Operation);

            // Ausgabe
            GibResultatAus(model.Resultat, Operation); 
            HoleBenutzerEingabe("Zum beenden bitte Return drücken !");
        }

        

        static string HoleBenutzerEingabe(string ausgabeText)
        {
            Console.Write(ausgabeText);
            string Zahl = Console.ReadLine();

            return Zahl;
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
