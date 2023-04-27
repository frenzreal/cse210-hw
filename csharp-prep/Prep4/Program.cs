using System;

class Program
{
    static void Main(string[] args)
    {
        List<int> numbers = new List<int>();
        int numb = -1;
        Console.WriteLine("Enter a list of numbers, type 0 when finished.");
        while (numb != 0)
        {
            Console.Write("Enter a number: ");
            numb = int.Parse(Console.ReadLine());
            if  (numb != 0)
            {
                numbers.Add(numb);
            }

        }
        // Console.WriteLine($"The sum is: {numbers.Sum()}");
        // Console.WriteLine($"The average is: {numbers.Average()}");
        // Console.WriteLine($"The largest number is: {numbers.Max()}");

        // Computing for the Sum
        int sum = 0;
        foreach (int number in numbers) 
        {
            sum += number;
        }
        Console.WriteLine($"The sum is: {sum}");

        // Computing the average
        float average = ((float)sum) / numbers.Count;
        Console.WriteLine($"The average is: {average}");

        // Finding the largest number
        int max = numbers[0];
        foreach (int number in numbers)
        {
            if (number > max)
            {
                max = number;
            }
        }
        Console.WriteLine($"The largest number is: {max}");

    }
}