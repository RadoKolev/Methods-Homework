using System;

// Write a method GetMax() with two parameters that returns the larger of two integers. Write a program that reads 2 integers from the console and prints the largest of them using the method GetMax().

// Sample Code                                          Input           Output

// int firstNumber = int.Parse(Console.ReadLine());     4               4
// int secondNumber = int.Parse(Console.ReadLine());    -5

// int max = GetMax(firstNumber, secondNumber);
// Console.WriteLine(max);
class BiggerNumber
{
    static void Main()
    {
        Console.Write("Please enter your first number: ");
        int firstNumber = int.Parse(Console.ReadLine());
        Console.Write("Please enter your second number: ");
        int secondNumber = int.Parse(Console.ReadLine());

        int max = GetMax(firstNumber, secondNumber);
        Console.WriteLine("Output: ", max);
    }

    static int GetMax(int first,int second)
    {
        int maxNumber = Math.Max(first, second);
        Console.WriteLine(maxNumber);
    }
}