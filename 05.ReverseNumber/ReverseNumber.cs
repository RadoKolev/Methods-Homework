using System;

// Write a method that reverses the digits of a given floating-point number.

// Sample Code                                             Input       Output

// double reversed = GetReversedNumber(123.45);            256         652
// Console.WriteLine(reversed);                            123.45      54.321
//                                                         0.12        21

using System.Linq;

class ReverseNumber
{
    static void Main()
    {
        Console.WriteLine("Please enter your number: ");
        double number = Double.Parse(Console.ReadLine());

        double reversed = GetReversedNumber(number);
        Console.WriteLine("Reversed number: " + reversed);
    }

    static double GetReversedNumber(double number)
    {
        string reverse = String.Join("", number.ToString().Reverse().ToArray());
        return Convert.ToDouble(reverse);
    }
}