using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp6
{
    class Program
    {
        static void Main(string[] args)
        {



            int liczba;
           

            Console.WriteLine("podaj liczbe");
            liczba = Convert.ToInt32(Console.ReadLine());
            if (liczba % 3 == 0 && liczba % 5 != 0)
                Console.WriteLine("Fizz");
            else
                if (liczba % 5 == 0 && liczba % 3 != 0)
                Console.WriteLine("Buzz");
            else
                if (liczba % 5 == 0 && liczba % 3 == 0)
                Console.WriteLine("FizzBuzz");
            else
                liczba = Convert.ToInt32(Console.ReadLine());
           

        }
       
       
        
    }
}
