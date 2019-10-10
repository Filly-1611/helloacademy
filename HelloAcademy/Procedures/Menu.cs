using System;
using System.Collections.Generic;
using System.Text;
using HelloAcademy.Utils;

namespace HelloAcademy.Procedures
{
    public static class Menu
    {
        public static void VisualizzaMenu()
        {
            Console.WriteLine("**************************");

            Console.WriteLine("*** HELLO ACADEMY MENU ***");
            Console.WriteLine("**************************");
            Console.WriteLine("");
            Console.WriteLine("* 1 - Divisione");
            Console.WriteLine("* 2 - Rubrica semplice");
            Console.WriteLine("* 3 - Rubrica complessa");
            Console.WriteLine("* 0 - Exit");
            Console.Write("* Selezione: ");
            var selezione = ConsoleUtils.LeggiNumeroInteroDaConsole(1, 3);

            switch (selezione)
            {

                case 1:
                    FunzioniMatematiche.RecuperaDivisioneEDividendoEDividi();
                    break;
                case 2:
                    FunzioniRubrica.InserisciPersoneEMostraRubrica();
                    break;
                case 3:
                    FunzioniRubrica.InserisciNumeroArbitrarioPersoneInRubrica();
                    break;
                case 0:
                    Console.WriteLine("Uscita....");
                    break;
                default:
                    Console.WriteLine("Selezione non valida");
                    break;
            }
        }
    }
}
