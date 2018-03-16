//CONFIRMED from tellniko
using System;

namespace _02._Rectangle_Area
{
    class Program
    {
        static void Main(string[] args)
        {
            //Variable for width
            decimal width = decimal.Parse(Console.ReadLine());
            //Variable for height
            decimal height = decimal.Parse(Console.ReadLine()); ;
            //Area for calculation
            decimal area = width * height;
            //Print the calculation
            Console.WriteLine("{0:f2}", area);
        }
    }
}
