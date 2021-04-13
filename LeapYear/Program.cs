using System;

namespace LeapYear
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Type a year, i'll tell you if it was a leapyear.");
            int year = Convert.ToInt32(Console.ReadLine());
            IsLeap(year);
        }
        static void IsLeap(int year)
        {
            if ((year % 4) == 0)
            {
                if ((year % 100) == 0)
                {
                    if ((year % 400) == 0)
                    {
                        Console.WriteLine($"{year} is a leapyear.");
                    }

                    else
                    {
                        Console.WriteLine($"{year} is not a leapyear.");
                    }

                }

                else
                {
                    Console.WriteLine($"{year} is a leapyear.");
                }

            }

            else
            {
                Console.WriteLine($"{year} is not a leapyear.");
            }
        }
    }
}
