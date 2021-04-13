using System;

namespace Enum_season
{
    class Program
    {
        enum Months {Januari = 1, Febuary, March, April, May, June, July, August, September, October, November, December}
        static void Main(string[] args)
        {
            Console.WriteLine("Give me the number of a month, i'll tell you which season it is.");
            int month = Convert.ToInt32(Console.ReadLine());
            Months season = (Months)month;
            switch (season)
            {
                case Months.December: case Months.Januari: case Months.Febuary:
                    Console.WriteLine("It's winter");
                    break;
                case Months.March: case Months.April: case Months.May:
                    Console.WriteLine("It's spring");
                    break;
                case Months.June: case Months.July: case Months.August:
                    Console.WriteLine("It's summer");
                    break;
                case Months.September: case Months.October: case Months.November:
                    Console.WriteLine("It's autumn");
                    break;
                default:
                    Console.WriteLine("Invalid");
                    break;
            }

            if (month <= 2 || month >= 9)
            {
                Console.WriteLine("It's gonna be cold.");
            }

            else
            {
                Console.WriteLine("It's gonna be warm.");
            }
        }
    }
}
