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
            ConsoleView view = new ConsoleView();

            string Operation = view.HoleBenutzerEingabe("Bitte gib die gewünschte Operation ein (+ - * /): ");
            string erstersteZahlAlsString = view.HoleBenutzerEingabe ("Bitte gib die erste Zahl ein: ");
            string zweiteZahlAlsString = view.HoleBenutzerEingabe("Bitte gib die zweite Zahl ein: ");
            
            // Wandel Text in Gleitkommazahlen
            // TODO: Auslagern in Methode, wenn Struktur umfangreicher geworden ist.
            double ersteZahl = Convert.ToDouble(erstersteZahlAlsString);
            double zweiteZahl = Convert.ToDouble(zweiteZahlAlsString);

            // Berechnung ausführen
            RechnerModel model = new RechnerModel();
            model.Berechne(ersteZahl, zweiteZahl, Operation);

            // Ausgabe
            view.GibResultatAus(model.Resultat, Operation);
            view.HoleBenutzerEingabe("Zum beenden bitte Return drücken !");
        }
    }
}
