using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Area_Of_Circle
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double pi = 3.14;

            int radius = 5;

            double area = pi * radius * radius;

            System.Console.WriteLine(area);

            System.Console.Read();
        }
    }
}
