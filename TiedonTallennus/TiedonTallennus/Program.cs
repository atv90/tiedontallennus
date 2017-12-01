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
            int lampotila = 0;
            Console.Write("Anna uusi lämpötila: ");
            String Syöte = Console.ReadLine();
            lampotila = int.Parse(Syöte);

            //tiedostoon kirjoittaminen

            String tiedosto = @"C:\Users\Anne\Documents\OhjJatkoPaiva2Esimerkki\Lämpotila.txt";

            File.WriteAllText(tiedosto, lampotila.ToString());
            Console.WriteLine("Uusi lämpötila tallennettu.");

            Console.ReadLine();
        }
    }
}
