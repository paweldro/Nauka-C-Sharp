using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ucze_sie
{
    class Program
    {
        static void Main(string[] args)
        {
            string imie;
            string nazwisko;
            int wiek;

            Console.Write("Podaj swoje imię: ");
            imie = Console.ReadLine();

            Console.Write("Podaj swoje nazwisko: ");
            nazwisko = Console.ReadLine();

            wiek = Convert.ToInt32(Console.ReadLine()); // DZiała tak samo jak wiek =Console.Read();
            Console.WriteLine();
            Console.WriteLine("Witaj {0} {1}, widzę, że masz {2} lat", imie, nazwisko, wiek);
        }
    }
}
