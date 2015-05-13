using System;
using System.Linq;

// Write methods to calculate the minimum, maximum, average, sum and product of a given set of numbers. Overload the methods to work with numbers of type double and decimal.

// Note: Do not use LINQ.

class NumberCalculations
{
    static void Main()
    {
        Console.WriteLine("Please enter numbers of type double on a single line, separated by a space: ");
        double[] doubleNumbers = Console.ReadLine().Split(' ').Select(double.Parse).ToArray();

        Console.WriteLine("Please enter numbers of type decimal on a single line, separated by a space: ");
        decimal[] decimalNumbers = Console.ReadLine().Split(' ').Select(decimal.Parse).ToArray();

        Console.WriteLine("The minimum of the given set of double numbers is: " + GetMin(doubleNumbers));
        Console.WriteLine("The maximum of the given set of double numbers is: " + GetMax(doubleNumbers));
        Console.WriteLine("The average of the given set of double numbers is: " + GetAverage(doubleNumbers));
        Console.WriteLine("The sum of the given set of double numbers is: " + GetSum(doubleNumbers));
        Console.WriteLine("The product of the given set of double numbers is: " + GetProduct(doubleNumbers));

        Console.WriteLine("The minimum of the given set of decimal numbers is: " + GetMin(decimalNumbers));
        Console.WriteLine("The maximum of the given set of decimal numbers is: " + GetMax(decimalNumbers));
        Console.WriteLine("The average of the given set of decimal numbers is: " + GetAverage(decimalNumbers));
        Console.WriteLine("The sum of the given set of decimal numbers is: " + GetSum(decimalNumbers));
        Console.WriteLine("The product of the given set of decimal numbers is: " + GetProduct(decimalNumbers));
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