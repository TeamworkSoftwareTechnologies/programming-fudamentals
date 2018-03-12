using System;

namespace _03._Miles_to_kilometers
{
    class Program
    {
        static void Main(string[] args)
        {
            //Declaring input variable
            double kilometeres = double.Parse(Console.ReadLine());
            
            //Converting from kilometers to miles
            //1 mile == 1.60934 kilometers
            double miles = (kilometeres * 1.60934);
            
            //Printing on Console converted variable    
            Console.WriteLine($"{miles:F2}");
        }
    }
}
