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
        Console.WriteLine($"The sum is: {numbers.Sum()}");
        Console.WriteLine($"The average is: {numbers.Average()}");
        Console.WriteLine($"The largest number is: {numbers.Max()}");

    }
}