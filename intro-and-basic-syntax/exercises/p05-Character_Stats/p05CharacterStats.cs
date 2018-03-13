using System;

namespace Character_Stats
{
    class Program
    {
        static void Main(string[] args)
        {
            //here we take the value from console
            var name = Console.ReadLine();
            int currentHealth = int.Parse(Console.ReadLine());
            int maxHealth = int.Parse(Console.ReadLine());
            int currentEnergy = int.Parse(Console.ReadLine());
            int maxEnergy = int.Parse(Console.ReadLine());

            //set how many strips and dots we have made by values 
            var pipesHealth = new string('|', currentHealth);
            var dotsHealth = new string('.', maxHealth - currentHealth);
            var pipesEnergy = new string('|', currentEnergy);
            var dotsEnergy = new string('.', maxEnergy - currentEnergy);

            //print the result
            Console.WriteLine("Name: " + name);
            Console.WriteLine("Health: |" + pipesHealth + dotsHealth + "|");
            Console.WriteLine("Energy: |" + pipesEnergy + dotsEnergy + "|");
            
            //result is something like that:
            // |||||||...|
            // |||||||||||
            // ||........|
        }
    }
}
