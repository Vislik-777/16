using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp50
{
    class Program
    {
        static void Main()
        {
            var p1 = new Point(1, 2);
            var p2 = new Point(3, 4);
            Console.WriteLine(p1 + p2); // (4, 6)
            Console.WriteLine(p2 - p1); // (2, 2)
        }
    }
}