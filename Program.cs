using System.Configuration;

using databaseAPI;

using GNAgeneraltools;

using GNAspreadsheettools;

using GNAchartingtools;

using OfficeOpenXml;



#pragma warning disable CS0162
#pragma warning disable CS8600
#pragma warning disable CS8604
#pragma warning disable IDE0059
#pragma warning disable IDE0060

//=====[Comments]============
//
// 20240209 Program created

//=====[Main menu]===========

namespace dataAnalysis
{

    class Program
    {

        static void Main(string[] args)
        {

programStart:
            string strSelection = "";

            Console.WriteLine("\nData analysis: ");
            Console.WriteLine("\n1. Check Environment");
            Console.WriteLine("2. Populate the point names table");
            Console.WriteLine("3. Import reference coordinates");
            Console.WriteLine("4. Import observed coordinates");
            Console.WriteLine("5. Generate mean dT and dH for timeblocks");
            Console.WriteLine("6. Plot charts");


            Console.WriteLine("\n0. Exit");
            do
            {
                Console.Write("\nSelect option: ");
                strSelection = Console.ReadKey().KeyChar.ToString();
            } while (strSelection.IndexOfAny(new char[] { '0', '1', '2', '3', '4', '5' }) == -1);

            Console.WriteLine("\n\n");

            switch (strSelection)
            {

                case "1":
                    Console.WriteLine("\n   Environment checked");
                    Console.WriteLine("Press key..."); Console.ReadKey();
                    Console.Clear();
                    goto programStart;  // backward GoTo aaargh
                    break;
                case "2":
                    Console.WriteLine("\n   Point names imported");
                    Console.WriteLine("Press key..."); Console.ReadKey();
                    Console.Clear();
                    goto programStart;  // backward GoTo aaargh
                    break;
                case "3":
                    Console.WriteLine("\n   Reference coordinates imported");
                    Console.WriteLine("Press key..."); Console.ReadKey();
                    Console.Clear();
                    goto programStart;  // backward GoTo aaargh
                    break;
                case "4":
                    Console.WriteLine("\n   Observed coordinates imported");
                    Console.WriteLine("Press key..."); Console.ReadKey();
                    Console.Clear();
                    goto programStart;  // backward GoTo aaargh
                    break;
                case "5":
                    Console.WriteLine("\n   dT and dH computed for timeblocks");
                    Console.WriteLine("Press key..."); Console.ReadKey();
                    Console.Clear();
                    goto programStart;  // backward GoTo aaargh
                    break;
                case "6":
                    Console.WriteLine("\n   Charts plotted");
                    Console.WriteLine("Press key..."); Console.ReadKey();
                    Console.Clear();
                    goto programStart;  // backward GoTo aaargh
                    break;
                default:
                    Console.WriteLine("Unknown...");
                    Console.WriteLine("Press key..."); Console.ReadKey();
                    Console.Clear();
                    goto programStart;  // backward GoTo aaargh
                    break;




                    Console.WriteLine("Done...");
                    Console.WriteLine("Press key..."); Console.ReadKey();
                    Environment.Exit(0);

            }
        }
    }
}