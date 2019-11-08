using System;
using System.Collections.Generic;

namespace Ryggsacken_del1
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

                if (valstr == "")
                {
                    Console.WriteLine("Välj ett alternativ från menyn: ");
                }
                else
                {
                    switch(valstr)
                    {
                        case "1":
                            Console.Write("Lägg till ett föremål: ");
                            var ltForemal = Console.ReadLine();
                            lsForemal.Add(ltForemal);
                            Console.WriteLine($"Du lade till: {ltForemal} ");
                            break;
                        case "2":
                            Console.WriteLine("Skriver ut innehåll... ");

                            foreach (string item in lsForemal)
                            {
                            Console.WriteLine(item);
                            }
                        
                            break;
                        case "3":
                            Console.Write("Är du säker på att du vill rensa innehållet [y]/[n]? ");
                            string rensa = Console.ReadLine();

                            if (rensa == "y")
                            {
                            Console.WriteLine("Rensar innehåll... ");
                            lsForemal.Clear();
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
