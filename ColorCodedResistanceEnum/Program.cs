using System;

namespace ColorCodedResistanceEnum
{
    class Program
    {
        enum Colors {silver = -2, gold, black, brown, red, orange, yellow, green, blue, purple, gray, white}
        static void Main(string[] args)
        {
            Console.WriteLine("What colour is the first ring?");
            int firstRing = ColourToNumber(Console.ReadLine());

            Console.WriteLine("What colour is the second ring?");
            int secondRing = ColourToNumber(Console.ReadLine());

            Console.WriteLine("What colour is the third ring?");
            int thirdRing = ColourToNumber(Console.ReadLine());

            double resistance = ((double)(10 * firstRing + secondRing) * Math.Pow(10, thirdRing));

            Console.WriteLine($"The restistor has a restance of {resistance} Ohm");
        }
        static int ColourToNumber(string colour)
        {
            colour = colour.ToLower();
            switch (colour)
            {
                case "black":
                    return (int)Colors.black;
                case "brown":
                    return (int)Colors.brown;
                case "red":
                    return (int)Colors.red;
                case "orange":
                    return (int)Colors.orange;
                case "yellow":
                    return (int)Colors.yellow;
                case "green":
                    return (int)Colors.green;
                case "blue":
                    return (int)Colors.blue;
                case "purple":
                    return (int)Colors.purple;
                case "gray":
                    return (int)Colors.gray;
                case "white":
                    return (int)Colors.white;
                case "gold":
                    return (int)Colors.gold;
                case "silver":
                    return (int)Colors.silver;
                default:
                    Console.WriteLine("This is not a valid Colour, try again");
                    return ColourToNumber(Console.ReadLine());

            }
        }
    }
}

