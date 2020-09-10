using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Taschenrechner
{
    class RechnerModel
    {
        public double Resultat { get; private set; }

        public RechnerModel()
        {
            Resultat = 0;
        }

        public void Berechne(double ersteZahl, double zweiteZahl, string Operation)
        {
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
        }
        private double Addiere(double ersterSummand, double zweiterSummand)
        {
            double Resultat = ersterSummand + zweiterSummand;

            return Resultat;
        }

        private double Subtrahiere(double Minuend, double Subtrahend)
        {
            double Resultat = Minuend - Subtrahend;

            return Resultat;
        }

        private double Multipliziere(double Multiplikator, double Multiplikand)
        {
            double Resultat = Multiplikator * Multiplikand;

            return Resultat;
        }

        private double Dividiere(double Dividend, double Divisior)
        {
            double Resultat = Dividend / Divisior;

            return Resultat;
        }
    }
}
