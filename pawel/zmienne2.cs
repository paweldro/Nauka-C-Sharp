using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int pierwsza;
            int druga;
            /*
            int i = 0; 
             i = i + 1; // i = i + 15      
             i += 1; // += 15 // i-= 15
             i++; // tylko o jeden (i--)
                  // operator modulo %     5%2 = 1   3%5 = 3 
             Console.WriteLine(i);
             Console.WriteLine(7 % i);
             */
            Console.WriteLine("podaj pierwszą liczbe: ");
            pierwsza = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("podaj drugą liczbe: ");
            druga = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("{0} % {1} = {2}", pierwsza, druga, pierwsza % druga);
        }
    }
}
