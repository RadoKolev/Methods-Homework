using System;
using System.Globalization;

// Write methods to calculate the minimum, maximum, average, sum and product of a given set of numbers. Overload the methods to work with numbers of type double and decimal.

// Note: Do not use LINQ.

class NumberCalculations
{
    static void Main()
    {
        Console.Write("Please enter your numbers on a single line, separated by a space: ");
        // reading double
        double input = Console.ReadLine();
        double[] doubleNumbers = input.Split(' ');
        double[] arr = new double[doubleNumbers.Length];
        for (int i = 0; i < doubleNumbers.Length; i++)
        {
            arr[i] = double.Parse(doubleNumbers[i]);
        }

        // reading decimal
        // string input = Console.ReadLine();
        // string[] decimalNumbers = input.Split(' ');
        // decimal[] arr = new decimal[decimalNumbers.Length];
        // for (int i = 0; i < decimalNumbers.Length; i++)
        // {
        //     arr[i] = decimal.Parse(decimalNumbers[i]);
        // }

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
    private static double GetMin(double[] arr)
    {
        double min = double.MaxValue;
        for (int i = 0; i < arr.Length; i++)
        {
            if (arr[i] < min)
            {
                min = arr[i];
            }
        }
        return min;
    }
    //private static decimal GetMin(decimal[] arr)
    //{
    //    decimal min = decimal.MaxValue;
    //    for (int i = 0; i < arr.Length; i++)
    //    {
    //        if (arr[i] < min)
    //        {
    //            min = arr[i];
    //        }
    //    }
    //    return min;
    //}
    private static double GetMax(double[] arr)
    {
        double max = double.MinValue;
        for (int i = 0; i < arr.Length; i++)
        {
            if (arr[i] > max)
            {
                max = arr[i];
            }
        }
        return max;
    }
    //private static decimal GetMax(decimal[] arr)
    //{
    //    decimal max = decimal.MinValue;
    //    for (int i = 0; i < arr.Length; i++)
    //    {
    //        if (arr[i] > max)
    //        {
    //            max = arr[i];
    //        }
    //    }
    //    return max;
    //}
    private static double GetAverage(double[] arr)
    {
        double sum = 0;
        for (int i = 0; i < arr.Length; i++)
        {
            sum += arr[i];
        }
        return sum / arr.Length;
    }
    //private static decimal GetAverage(decimal[] arr)
    //{
    //    decimal sum = 0;
    //    for (int i = 0; i < arr.Length; i++)
    //    {
    //        sum += arr[i];
    //    }
    //    return sum / arr.Length;
    //}
    private static double GetSum(double[] arr)
    {
        double sum = 0;
        for (int i = 0; i < arr.Length; i++)
        {
            sum += arr[i];
        }
        return sum;
    }
    //private static decimal GetSum(decimal[] arr)
    //{
    //    decimal sum = 0;
    //    for (int i = 0; i < arr.Length; i++)
    //    {
    //        sum += arr[i];
    //    }
    //    return sum;
    //}
    private static double GetProduct(double[] arr)
    {
        double product = 1;
        for (int i = 0; i < arr.Length; i++)
        {
            product *= arr[i];
        }

        return product;
    }
    //private static decimal GetProduct(decimal[] arr)
    //{
    //    decimal product = 1;
    //    for (int i = 0; i < arr.Length; i++)
    //    {
    //        product *= arr[i];
    //    }

    //    return product;
    //}
}