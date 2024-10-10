using System;
namespace uppgift2_3
{ class Program
    { static void Main(string[] args)
        {
            Console.WriteLine("Hur många dagar ska du köra denna bil");
            string dagar  =Console.ReadLine();
           Console.WriteLine("Hur många kilometer ska du köra");
            int tal = int.Parse(dagar);
            string kilometer = Console.ReadLine();
            int tal2 = int.Parse(kilometer);
            int bannan = tal * 500 + tal2 * 1 + 300;
            Console.WriteLine("Det kommer att kosta " + bannan);
        }
    }
}
