using System;
using System.IO;
using System.Linq;

// Write methods to calculate the minimum, maximum, average, sum and product of a given set of numbers. Overload the methods to work with numbers of type double and decimal.

// Note: Do not use LINQ.

class NumberCalculations
{
    static void Main()
    {
        Console.WriteLine("Please enter your numbers on a single line, separated by a space: ");

        double[] doubleNumbers = Console.ReadLine().Split(' ').Select(double.Parse).ToArray();

        decimal[] decimalNumbers = Console.ReadLine().Split(' ').Select(decimal.Parse).ToArray();

        Console.WriteLine(GetMin(doubleNumbers));
        Console.WriteLine(GetMax(doubleNumbers));
        Console.WriteLine(GetAverage(doubleNumbers));
        Console.WriteLine(GetSum(doubleNumbers));
        Console.WriteLine(GetProduct(doubleNumbers));

        Console.WriteLine(GetMin(decimalNumbers));
        Console.WriteLine(GetMax(decimalNumbers));       
        Console.WriteLine(GetAverage(decimalNumbers));
        Console.WriteLine(GetSum(decimalNumbers));
        Console.WriteLine(GetProduct(decimalNumbers));
    }
    static double GetMin(double[] set)
    {
        double min = double.MaxValue;
        for (int i = 0; i < set.Length; i++)
        {
            if (set[i] < min)
            {
                min = set[i];
            }
        }
        return min;
    }
    private static decimal GetMin(decimal[] set)
    {
        decimal min = decimal.MaxValue;
        for (int i = 0; i < set.Length; i++)
        {
            if (set[i] < min)
            {
                min = set[i];
            }
        }
        return min;
    }
    private static double GetMax(double[] set)
    {
        double max = double.MinValue;
        for (int i = 0; i < set.Length; i++)
        {
            if (set[i] > max)
            {
                max = set[i];
            }
        }
        return max;
    }
    private static decimal GetMax(decimal[] set)
    {
        decimal max = decimal.MinValue;
        for (int i = 0; i < set.Length; i++)
        {
            if (set[i] > max)
            {
                max = set[i];
            }
        }
        return max;
    }
    private static double GetAverage(double[] set)
    {
        double sum = 0;
        for (int i = 0; i < set.Length; i++)
        {
            sum += set[i];
        }
        return sum / set.Length;
    }
    private static decimal GetAverage(decimal[] set)
    {
        decimal sum = 0;
        for (int i = 0; i < set.Length; i++)
        {
            sum += set[i];
        }
        return sum / set.Length;
    }
    private static double GetSum(double[] set)
    {
        double sum = 0;
        for (int i = 0; i < set.Length; i++)
        {
            sum += set[i];
        }
        return sum;
    }
    private static decimal GetSum(decimal[] set)
    {
        decimal sum = 0;
        for (int i = 0; i < set.Length; i++)
        {
            sum += set[i];
        }
        return sum;
    }
    private static double GetProduct(double[] set)
    {
        double product = 1;
        for (int i = 0; i < set.Length; i++)
        {
            product *= set[i];
        }

        return product;
    }
    private static decimal GetProduct(decimal[] set)
    {
        decimal product = 1;
        for (int i = 0; i < set.Length; i++)
        {
            product *= set[i];
        }

        return product;
    }
}
}