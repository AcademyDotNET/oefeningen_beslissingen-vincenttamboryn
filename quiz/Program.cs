using System;

namespace quiz
{
    class Program
    {
        static void Main(string[] args)
        {
            int points = 0;

            Console.WriteLine("how do you write 37 in binairy?");
            Console.WriteLine("a 100100");
            Console.WriteLine("b 101100");
            Console.WriteLine("c 100001");
            Console.WriteLine("d 100101");
            string guess = Console.ReadLine();

            switch (guess)
            {
                case "a":
                    Console.WriteLine("This is not correct, -1 point");
                    points = points - 1;
                    break;

                case "b":
                    Console.WriteLine("This is not correct, -1 point");
                    points = points - 1;
                    break;

                case "c":
                    Console.WriteLine("This is not correct, -1 point");
                    points = points - 1;
                    break;

                case "d":
                    Console.WriteLine("This is correct, +2 points");
                    points = points + 2;
                    break;

                default:
                    Console.WriteLine("That is not an acceptable answer, -1000 points");
                    points = points - 1000;
                    break;
            }

            Console.WriteLine($"You currently have {points} points");

            Console.WriteLine("how fast is the speed of sound?");
            Console.WriteLine("a 300 m/s");
            Console.WriteLine("b 350 m/s");
            Console.WriteLine("c 1000 m/s");
            Console.WriteLine("d 250 m/s");

            guess = Console.ReadLine();
            switch (guess)
            {
                case "a":
                    Console.WriteLine("This is correct, +2 points");
                    points = points + 2;
                    break;

                case "b":
                    Console.WriteLine("This is not correct, -1 point");
                    points = points - 1;
                    break;

                case "c":
                    Console.WriteLine("This is not correct, -1 point");
                    points = points - 1;
                    break;

                case "d":
                    Console.WriteLine("This is not correct, -1 point");
                    points = points - 1;
                    break;


                default:
                    Console.WriteLine("That is not an acceptable answer, -1000 points");
                    points = points - 1000;
                    break;
            }

            Console.WriteLine($"You currently have {points} points");

            Console.WriteLine("Which among the following laws explains the ‘spectrum of blackbody radiation?");
            Console.WriteLine("a Planck's law");
            Console.WriteLine("b Wien's displacement law");
            Console.WriteLine("c Stefan–Boltzmann law");
            Console.WriteLine("d Charles's law");

            guess = Console.ReadLine();
            switch (guess)
            {
                case "a":
                    Console.WriteLine("This is correct, +2 points");
                    points = points + 2;
                    break;

                case "b":
                    Console.WriteLine("This is not correct, -1 point");
                    points = points - 1;
                    break;

                case "c":
                    Console.WriteLine("This is not correct, -1 point");
                    points = points - 1;
                    break;

                case "d":
                    Console.WriteLine("This is not correct, -1 point");
                    points = points - 1;
                    break;


                default:
                    Console.WriteLine("That is not an acceptable answer, -1000 points");
                    points = points - 1000;
                    break;
            }
            Console.WriteLine($"Congratulations, you finished with {points} points");
        }
    }
}
