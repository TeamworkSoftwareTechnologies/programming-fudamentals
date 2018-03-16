using System;  

  

namespace BeverageLabels  

{  

    class Program  

    {  

        static void Main(string[] args)  

        {  

            string foodname = Console.ReadLine();  

            int foodvolume = int.Parse(Console.ReadLine()); 

   

            double energyContentPer100 = double.Parse(Console.ReadLine());  

            double sugarContentPer100 = double.Parse(Console.ReadLine());  

            Console.WriteLine($"{foodvolume}ml {foodname}:\r\n{energyContentPer100*foodvolume/100}kcal, {sugarContentPer100*foodvolume/100}g sugars");  

        }  

    }  

}