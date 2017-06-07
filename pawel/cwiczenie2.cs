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
            double a;
            double b;
            double c;

            Console.WriteLine("podaj a");
           a = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("podaj b");
            b = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("podaj c");
            c = Convert.ToDouble(Console.ReadLine());

            if (a > b && c < a && c > b)
                Console.WriteLine("jo");
            if (a < b && c > a && c < b)
                Console.WriteLine("tyż jo");
            else
                Console.WriteLine("zdezydowanie nie jo");



        }
       
       
        
    }
}
