using System;

class CreditCardNumber
{
    static void Main(string[] args)
    {
        int firstNum = int.Parse(Console.ReadLine());
        int secondNum = int.Parse(Console.ReadLine());
        int tirdNum = int.Parse(Console.ReadLine());
        int fourthNum = int.Parse(Console.ReadLine());

        Console.WriteLine($"{firstNum:D4} {secondNum:D4} {tirdNum:D4} {fourthNum:D4}");
    }
}

