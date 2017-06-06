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
            // Pętla while
            int zmienna = 0;
            bool udaloSie = false;
            while (!udaloSie)
            {
                zmienna++;
                if (zmienna == 15)
                {
                    udaloSie = true;
                }
            }

            // Pętla for(zmienna; warunek; inkrementacja) 
            int suma = 0;
            for(int i = 0; i < 50; i++)
            {
                suma += i;
            }
            Console.WriteLine(suma);
            

            // Pętla do while zawsze wykona się choć jeden raz
            do
            {
                Console.WriteLine("Fajno");
            } while (false);
        }
    }
}
