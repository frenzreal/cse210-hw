using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("What is your grade percentage? ");
        string percentage = Console.ReadLine();
        int percent = int.Parse(percentage);

        string letter = "";
        string sign = "";

        // Computation for the letter equivalent of the grade input by the user
        if ( percent >= 90 )
        {
            letter = "A";
        }

        else if ( percent < 90 && percent >= 80 )
        {
            letter = "B";
        }

        else if ( percent < 80 && percent >= 70 )
        {
            letter = "C";
        }

        else if ( percent < 70 && percent >= 60 )
        {
            letter = "D";
        }

        else
        {
            letter = "F";
        }

        //Determining the sign for the grade mark
        if ((percent%10) >= 7)
        {
            sign = "+";
        }
        else if ((percent%10) < 3)
        {
            sign = "-";
        }
        else
        {
            sign = "";
        }

        // Print output
        Console.WriteLine($"Your grade is: {letter}{sign}");

        // Determining whether the student passed or failed the course
        if (percent >= 70)
        {
            Console.Write("Congratulations, you passed the course!");
        }
        else
        {
            Console.Write("Keep on trying, don't ever give up");
        }

    }
}