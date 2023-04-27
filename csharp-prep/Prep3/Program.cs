using System;

class Program
{
    static void Main(string[] args)
    {
        int guess = -1;
        Random randomGenerator = new Random();
        int answer = randomGenerator.Next(1, 11);
        Console.WriteLine("Guess a number from 1 to 11");
        while (guess != answer)
        {
            Console.Write("What is your guess? ");
            guess = int.Parse(Console.ReadLine());
            if (guess < answer)
            {
                Console.WriteLine("Higher");
            }
            else if (guess > answer)
            {
                Console.WriteLine("Lower");
            }
            else
            {
                Console.WriteLine("You guessed it!");
            }
        }
    }
}