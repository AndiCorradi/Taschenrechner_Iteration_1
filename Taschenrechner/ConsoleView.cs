using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Taschenrechner
{
    class ConsoleView
    {
        public string HoleBenutzerEingabe(string ausgabeText)
        {
            Console.Write(ausgabeText);
            string Zahl = Console.ReadLine();

            return Zahl;
        }

        public void GibResultatAus(double Resultat, String Operation)
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
