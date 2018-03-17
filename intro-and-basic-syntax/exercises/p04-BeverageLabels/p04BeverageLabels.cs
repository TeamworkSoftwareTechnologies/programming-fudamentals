//CONFIRMED by Daniel-Takev
using System;  

namespace BeverageLabels 
{  
    class Program  

    {  
        static void Main(string[] args)  
        {  
            //delete useless rows
            //we recieve from the Console the name of the food -> string type
            string foodname = Console.ReadLine();  
            //recieve tree variables
            int foodvolume = int.Parse(Console.ReadLine()); 
            double energyContentPer100 = double.Parse(Console.ReadLine());  
            double sugarContentPer100 = double.Parse(Console.ReadLine());  

            //calculate and print the result
            Console.WriteLine($"{foodvolume}ml {foodname}:\r\n{energyContentPer100*foodvolume/100}kcal, {sugarContentPer100*foodvolume/100}g sugars");  

        }  
    }  
}