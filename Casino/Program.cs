using System;

namespace Casino
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 1;
            bool correct = true;
            while ((i <= 3) && (correct == true))
            { 
                Random mygen = new Random();
                int answer = mygen.Next(1, 6);

                Console.WriteLine("Guess a number between 1 and 6");
                int guess = Convert.ToInt32(Console.ReadLine());
                
                correct = Guess(guess, answer);
                i++;
                if (i > 3)
                { 
                    Console.WriteLine("Wow you did it! amazing");
                }
            }
        }
        static bool Guess(int guess, int answer)
        {
            if (guess == answer)
            {
                Console.WriteLine("Hurray! You guessed correctly! But can you do it again?");
                return true;
            }
            else
            {
                Console.WriteLine($"You Lose! The correct answer was {answer}. Better luck next time!");
                return false;
            }
        }
    }
}
