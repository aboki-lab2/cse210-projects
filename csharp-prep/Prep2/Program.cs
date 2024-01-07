using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("What is the percentage of your grade in the class work? ");
        string reply = Console.ReadLine();
        int percent = int.Parse(reply);

        string letter = "";

        if (percent >= 90)
        {
            letter = "A";
        }
        else if (percent >= 80)
        {
            letter = "B";
        }
        else if (percent >= 70)
        {
            letter = "C";
        }
        else if (percent >= 60)
        {
            letter = "D";
        }
        else
        {
            letter = "F";
        }

        Console.WriteLine($"Thank you for participating in the class this semester. Kindly note that your grade is: {letter}");
        
        if (percent >= 70)
        {
            Console.WriteLine("Your score gave you a pass mark. See you next semester!");
        }
        else
        {
            Console.WriteLine(" Sorry you performed badly. Better luck next time!");
        }
    }
}