//CONFIRMED from naseood
using System;

namespace Character_Stats
{
    class Program
    {
        static void Main(string[] args)
        {
            //here we take the value from console
            var nameOfCharacter = Console.ReadLine();
            int currentHealth = int.Parse(Console.ReadLine());
            int maxHealth = int.Parse(Console.ReadLine());
            int currentEnergy = int.Parse(Console.ReadLine());
            int maxEnergy = int.Parse(Console.ReadLine());

            //set how many strips and dots we have made by values 
            int pipesHealth = new string('|', currentHealth);
            int dotsHealth = new string('.', maxHealth - currentHealth);
            int pipesEnergy = new string('|', currentEnergy);
            int dotsEnergy = new string('.', maxEnergy - currentEnergy);

            //print the result
            Console.WriteLine("Name: " + nameOfCharacter);
            Console.WriteLine("Health: |" + pipesHealth + dotsHealth + "|");
            Console.WriteLine("Energy: |" + pipesEnergy + dotsEnergy + "|");
            
            //result is something like that:
            // |||||||...|
            // |||||||||||
            // ||........|
        }
    }
}
