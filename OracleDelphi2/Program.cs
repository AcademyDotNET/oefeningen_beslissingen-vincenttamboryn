using System;

namespace OracleDelphi2
{
    class Program
    {
        static void Main(string[] args)
        {
            RandomLifeExpectancy();
        }
        static void RandomLifeExpectancy()
        {
            Console.WriteLine("How old are you now?");
            int age = Convert.ToInt32(Console.ReadLine());
            if (age >= 120)
            {
                Console.WriteLine("I don't think I believe you. Try again!");
                RandomLifeExpectancy();
            }
            else
            { 
                Console.WriteLine("Are your male of female (m for male, f for female)?");
                string gender = Console.ReadLine();
                gender = gender.ToLower();

                int yearsToLive = 0;
                Random mygen = new Random();
                switch (gender)
                {
                    case  "m":
                        yearsToLive = 5 + mygen.Next(5, 125 - age);
                        Console.WriteLine($"I expect you to live to the ripe old age of {age + yearsToLive}");
                        break;
                    case "f":
                        yearsToLive = 5 + mygen.Next(5, 155 - age);
                        Console.WriteLine($"I expect you to live to the ripe old age of {age + yearsToLive}");
                        break;
                    default:
                        Console.WriteLine("Invalid, try a different oracle");
                        RandomLifeExpectancy();
                        break;
                }
            }
        }
    }
}
