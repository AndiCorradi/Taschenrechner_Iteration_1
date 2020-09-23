using System;

namespace Taschenrechner
{
    class ConsoleView
    {
        private RechnerModel model;

        public ConsoleView(RechnerModel model)
        {
            this.model = model;
            BenutzerWillBeenden = false;
        }

        public bool BenutzerWillBeenden { get; private set; }

        public void HoleEingabenVomBenutzer()
        {
            model.ErsteZahl = HoleZahlVomBenutzer();
            model.Operation = HoleOperatorVomBenutzer();
            model.ZweiteZahl = HoleZahlVomBenutzer();
        }
        
        private double HoleZahlVomBenutzer()
        {
            string eingabe;
            Console.Write("Bitte gib eine Zahl für die Berechnung ein (FERTIG zum beenden): ");
            eingabe = Console.ReadLine();

            if (eingabe == "FERTIG")
            {
                BenutzerWillBeenden = true;
                eingabe = "0,0";
            }

            return Convert.ToDouble(eingabe);
        }

        private string HoleOperatorVomBenutzer()
        {
            Console.Write("Bitte gib die auszuführende Operation ein (+, -, /, *): ");
            
            return Console.ReadLine();
        }

        public void WarteAufEndeDurchBenutzer()
        {
            Console.WriteLine("Zum beenden bitte Return drücken!");
            Console.ReadLine();
        }

        public void GibResultatAus()
        {
            switch (model.Operation)
            {
                case "+":
                    Console.WriteLine("Die Summe ist: {0}", model.Resultat);
                    break;

                case "-":
                    Console.WriteLine("Die Differenz ist: {0}", model.Resultat);
                    break;

                case "/":
                    Console.WriteLine("Der Quotione ist: {0}", model.Resultat);
                    break;

                case "*":
                    Console.WriteLine("Das Produkt ist: {0}", model.Resultat);
                    break;

                default:
                    Console.WriteLine("Du hast eine ungültige Operation eingegeben");
                    break;
            }
        }
    }
}
