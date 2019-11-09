using System;
using System.Collections.Generic;

namespace Ryggsacken_del2
{
    class Program
    {
        static void Main(string[] args)
        {
           
            var lsForemal = new List<string>();

            for ( ; ; )
            {
                Console.WriteLine();
                Console.WriteLine("Välkommen till ryggsäcken!");
                Console.WriteLine("[1] Lägg till ett föremål");
                Console.WriteLine("[2] Skriv ut innehållet");
                Console.WriteLine("[3] Rensa innehållet");
                Console.WriteLine("[4] Avsluta");
                Console.WriteLine("Välj:");
                Console.WriteLine();

                var valstr = Console.ReadLine();
                int antal = 6;

                if (valstr == "")
                {
                    Console.WriteLine("Välj ett alternativ från menyn: ");
                }
                else
                {
                    switch(valstr)
                    {
                        case "1":
                            Console.WriteLine("Du kan lägga till {0} föremål. ", antal);
                            Console.WriteLine("Du har lagt till {0} föremål. ", lsForemal.Count);

                            if (lsForemal.Count == antal)
                            {
                                Console.WriteLine("Du har redan lagt till {0} föremål. ", antal);
                                Console.WriteLine("Ta bort ett föremål för att lägga till fler. ", antal);
                                Console.WriteLine("Går tillbaka till menyn... ");
                            }
                            else
                            {
                                Console.Write("Lägg till ett föremål ");
                                Console.Write("(lämna blankt för att inte lägga till något): ");
                                string ltForemal = Console.ReadLine();
                                if (ltForemal == "")
                                {
                                    Console.WriteLine("Du lade inte till något föremål. ");
                                    Console.WriteLine("Går tillbaka till menyn... ");
                                }
                                else
                                {
                                    lsForemal.Insert(0 ,ltForemal);
                                    Console.WriteLine($"Du lade till: {ltForemal} ");
                                }
                            }
                            break;
                        case "2":
                            Console.WriteLine("Skriver ut innehåll ({0} av {1})... ", lsForemal.Count, antal);

                            foreach (string item in lsForemal)
                            {
                                Console.WriteLine(item);
                            }
                        
                            break;
                        case "3":
                            Console.Write("Är du säker på att du vill ta bort det senaste föremålet [y]/[n]? ");
                            string rensa = Console.ReadLine();

                            if (rensa == "y")
                            {
                                if (lsForemal.Count == 0)
                                {
                                    Console.WriteLine("Ryggsäcken är redan tom.");
                                    Console.WriteLine("Går tillbaka till menyn... ");
                                }
                                else
                                {
                                    Console.WriteLine("Rensar innehåll... ");
                                    lsForemal.RemoveAt(0);
                                }
                            }
                            else
                            {
                            Console.WriteLine("Går tillbaka till menyn... ");
                            }
                            break;
                        case "4":
                            Console.WriteLine("Avslutar ryggsäck... ");
                            return;
                        default:
                            Console.WriteLine("Välj ett alternativ från menyn: ");
                            break;
                    }
                }
            } 
        }
    }
}
