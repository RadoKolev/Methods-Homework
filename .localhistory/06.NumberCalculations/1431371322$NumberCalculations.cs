using System;
using System.IO;

// Write methods to calculate the minimum, maximum, average, sum and product of a given set of numbers. Overload the methods to work with numbers of type double and decimal.

// Note: Do not use LINQ.

class NumberCalculations
{
    private static void Main()
    {
        Console.WriteLine("Please enter your numbers on a single line, separated by a space: ");
        double inputDoubles = double.Parse(Console.ReadLine());
        double[] Double = inputDoubles.Split(' ');
        double[] dataArray = new double[inputDouble.Length];

        Console.WriteLine(GetMin(doubleNumbers));
        //Console.WriteLine(GetMin(decimalNums));
        Console.WriteLine(GetMax(doubleNumbers));
        //Console.WriteLine(GetMax(decimalNums));
        Console.WriteLine(GetAverage(doubleNumbers));
        //Console.WriteLine(GetAverage(decimalNums));
        Console.WriteLine(GetSum(doubleNumbers));
        //Console.WriteLine(GetSum(decimalNums));
        Console.WriteLine(GetProduct(doubleNumbers));
        //Console.WriteLine(GetProduct(decimalNums));
    }
}