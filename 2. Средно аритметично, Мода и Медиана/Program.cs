using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main()
    {
        Console.Write("Enter the list of numbers separated by space: ");
        List<int> numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToList();

        double mean = numbers.Average();
        int mode = numbers.GroupBy(n => n).OrderByDescending(g => g.Count()).Select(g => g.Key).FirstOrDefault();
        double median;
        numbers.Sort();
        if (numbers.Count % 2 == 0)
        {
            median = (numbers[numbers.Count / 2 - 1] + numbers[numbers.Count / 2]) / 2.0;
        }
        else
        {
            median = numbers[numbers.Count / 2];
        }

        Console.WriteLine($"Mean: {mean}, Mode: {mode}, Median: {median}");
    }
}
