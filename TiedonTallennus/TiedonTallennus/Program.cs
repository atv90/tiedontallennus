using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TiedonTallennus
{
    class Program
    {
        static void Main(string[] args)
        {
            String tiedosto = @"C:\Users\Anne\Documents\OhjJatkoPaiva2Esimerkki\Lämpotila.txt";

            //luetaan tiedostosta aiemmin asetettu lämpötila
            if (File.Exists(tiedosto))
            {
                string aiempiArvo = File.ReadAllText(tiedosto);
                Console.WriteLine("Aiemmin asetettu lämpötila on " + aiempiArvo + " astetta.");
            }
            else
            {
                Console.WriteLine("Tervetuloa!");
            }

            int lampotila = 0;

            //WriteLine lisää automaattisesti rivinvaihdon rivin loppuun
            //eli heittomerkkejä edeltävän merkin jälkeen
            //Write ei lisää rivinvaihtoa vaan kohdistin jää sille paikalleen
            Console.Write("Anna uusi lämpötila: ");
            String Syöte = Console.ReadLine();
            lampotila = int.Parse(Syöte);

            //tiedostoon kirjoittaminen


            File.WriteAllText(tiedosto, lampotila.ToString());
            Console.WriteLine("Uusi lämpötila tallennettu.");

            Console.ReadLine();
        }
    }
}
