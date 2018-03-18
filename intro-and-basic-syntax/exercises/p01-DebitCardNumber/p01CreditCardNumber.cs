//CONFIRMED from dmxice97
using System;

class CreditCardNumber
{
    static void Main(string[] args)
    {
        //here we take the names of person
        int firstNumber = int.Parse(Console.ReadLine());
        int secondNumber = int.Parse(Console.ReadLine());
        int thirdNumber = int.Parse(Console.ReadLine());
        int fourthNumber = int.Parse(Console.ReadLine());

        //here print them on the console
        Console.WriteLine($"{firstNum:D4} {secondNum:D4} {tirdNum:D4} {fourthNum:D4}");
    }
}

