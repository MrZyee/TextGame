using System;

namespace TextGame
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number, guess, tries = 0;
            Random random = new Random();
            Hint hint = new Hint();

            number = random.Next(1, 101); // The function draws any number between 1 and 100

            Console.WriteLine("Welcome! Guess the number from 1 to 100");

            do
            {
                Console.WriteLine("Enter the number: ");
                guess = int.Parse(Console.ReadLine());
                tries++;

                if (guess < number)
                {
                    Console.WriteLine("Too few! Try again");
                    if (tries > 3)
                    {
                        Hint.HintEvenNumbers(number);
                    }
                }
                else if (guess > number)
                {
                    Console.WriteLine("Too much! Try again");
                    if (tries > 3)
                    {
                        Hint.HintEvenNumbers(number);
                    }
                }
                else
                {
                    Console.WriteLine("Congratulations! You guessed it for " + tries + " togethe." );
                }

            } while (guess != number);

            Console.WriteLine("Thank you for the game!");
            Console.ReadKey();
        }
    }
}