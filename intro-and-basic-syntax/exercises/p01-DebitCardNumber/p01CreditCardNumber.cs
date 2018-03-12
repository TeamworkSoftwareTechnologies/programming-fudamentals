//CONFIRMED from dmxice97
using System;

class CreditCardNumber
{
    static void Main(string[] args)
    {
        //here we take the names of person
        int firstNum = int.Parse(Console.ReadLine());
        int secondNum = int.Parse(Console.ReadLine());
        int tirdNum = int.Parse(Console.ReadLine());
        int fourthNum = int.Parse(Console.ReadLine());

        //here print them on the console
        Console.WriteLine($"{firstNum:D4} {secondNum:D4} {tirdNum:D4} {fourthNum:D4}");
    }
}

