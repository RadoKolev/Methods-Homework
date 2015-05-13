using System;

// Write a method that returns the last digit of a given integer as an English word. Test the method with different input values. Ensure you name the method properly.

// Sample Code                                         Output 

// Console.WriteLine(GetLastDigitAsWord(512));         two
// Console.WriteLine(GetLastDigitAsWord(1024));        four
// Console.WriteLine(GetLastDigitAsWord(12309));       nine
class LastDigitOfNumber
{
    static void Main()
    {
        Console.Write("Please enter your number: ");
        int number = int.Parse(Console.ReadLine());

        Console.WriteLine("The last digit is: " + GetLastDigitAsWord(number));
    }

    static string GetLastDigitAsWord(int n)
    {
        int lastDigit = n % 10;
        string[] lastDigitAsWord = {"zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine"};

        return lastDigitAsWord[lastDigit];
    }
}