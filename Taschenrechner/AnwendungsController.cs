using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Taschenrechner
{
    class AnwendungsController
    {
        private ConsoleView view;
        private RechnerModel model;

        public AnwendungsController(ConsoleView view, RechnerModel model)
        {
            this.view = view;
            this.model = model;
        }

        public void Ausfuehren()
        {
            view.HoleEingabenVomBenutzer();

            // Berechnung ausführen
            model.Berechne();

            // Ausgabe
            view.GibResultatAus();
            view.WarteAufEndeDurchBenutzer();
        }
    }
}
