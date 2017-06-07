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
            double a, b, c;
            Console.Write("Podaj 3 liczby rzeczywiste: a, b, c: );
            a = Convert.ToDouble(Console.ReadLine());
            b = Convert.ToDouble(Console.ReadLine());
            c = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Czy liczba c zawiera się w przedziale (a,b) lub (b,a)\?  ");
            //----------------------------UZUPEŁNIJ  tam gdzie są znaki $$$
            if(a < b)
                if ($$$)    Console.WriteLine("TAK");
                else        Console.WriteLine("NIE");
            else
                if ($$$)    Console.WriteLine($$$);
                else        Console.WriteLine($$$);
             //----------------------------
        }
    }
}
