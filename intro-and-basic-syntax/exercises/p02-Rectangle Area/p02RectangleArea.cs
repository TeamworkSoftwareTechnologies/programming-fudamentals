//CONFIRMED from tellniko
using System;

namespace _02._Rectangle_Area
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal width = decimal.Parse(Console.ReadLine());
            decimal height = decimal.Parse(Console.ReadLine()); ;

            decimal area = width * height;

            Console.WriteLine("{0:f2}", area);
        }
    }
}
