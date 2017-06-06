using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            //sprawdza, która liczba większa
            int pierwsza;
            int druga;
            Console.WriteLine("podaj pierwszą liczbę: ");
            pierwsza = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("podaj drugą liczbę: ");
            druga = Convert.ToInt32(Console.ReadLine());

            if (pierwsza > druga)  //jak więcej instrukcji to daj {}, inaczej czyta jedną
                // >, <, >=. <=, ||, $$, == (operator porównania), != (różne)
                Console.WriteLine("Liczba {0} jest większa od {1}", pierwsza, druga);
            else if (pierwsza == druga)
                Console.WriteLine("podane liczby są równe");
            //w przeciwnym wypadku 
            else Console.WriteLine("Liczba {0} jest większa od {1}", druga, pierwsza);

            

            
          
        }
    }
}
