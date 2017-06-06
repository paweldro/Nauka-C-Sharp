using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            bool prawda = true;
            bool fałsz = false;

            // AND (logiczne I) && ^
            Console.WriteLine(prawda && prawda);

            // OR (logiczne lub) || V
            Console.WriteLine(false || true);

            // ! - negacja
            Console.WriteLine(!true);

            // zagadaka, i zawsze od środkaq jak w matmie
            Console.WriteLine(!((false || false) && true));
        }
    }
}
