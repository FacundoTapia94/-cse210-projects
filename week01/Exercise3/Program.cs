using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Welcome to the guess the number game!");
        Random randomGenerator = new Random();
        int number = randomGenerator.Next(1, 101); 

        int guessNumber = -1;

        while (guessNumber != number)
        {
            Console.Write("What is your guess? ");
            guessNumber = int.Parse(Console.ReadLine());

            if (guessNumber > number)
            {
                Console.WriteLine("Lower");
            }

            else if (guessNumber < number)
            {
                Console.WriteLine("Higher");
            }
            else

            {
            Console.WriteLine("You guessed it!");
            }

        }

        
        


    }
}