using System;

namespace ColourCodeRestistance
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What colour is the first ring?");
            int firstRing = ColourToNumber(Console.ReadLine());

            Console.WriteLine("What colour is the second ring?");
            int secondRing = ColourToNumber(Console.ReadLine());

            Console.WriteLine("What colour is the third ring?");
            int thirdRing = ColourToNumber(Console.ReadLine());
            double resistance = ((double)(10 * firstRing + secondRing) * Math.Pow(10 , thirdRing));

            Console.WriteLine($"The restistor has a restance of {resistance} Ohm");
        }
        static int ColourToNumber(string colour)
        {
            colour = colour.ToLower();
            switch (colour)
            {
                case "black":
                    return 0;
                case "brown":
                    return 1;
                case "red":
                    return 2;
                case "orange":
                    return 3;
                case "yellow":
                    return 4;
                case "green":
                    return 5;
                case "blue":
                    return 6;
                case "purple":
                    return 7;
                case "gray":
                    return 8;
                case "white":
                    return 9;
                case "gold":
                    return -1;
                case "silver":
                    return -2;
                default:
                    Console.WriteLine("This is not a valid Colour, try again");
                    return ColourToNumber(Console.ReadLine());

            }
        }
    }
}
