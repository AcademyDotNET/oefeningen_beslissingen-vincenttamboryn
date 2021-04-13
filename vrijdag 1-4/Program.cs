using System;

namespace BMI_met_if
{
    class Program
    {
        static void Main(string[] args)
        {
            double height = IsNumber("height", "meters");
            double weight = IsNumber("weight", "kilograms");
            double _BMI = Math.Round(weight / (Math.Pow(height, 2)), 2);

            if (_BMI < 18.5)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine($"Your current BMI is {_BMI}");
            }
            else if ((18.5 <= _BMI) && (_BMI < 25))
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine($"Your current BMI is {_BMI}");
            }
            else if ((25 <= _BMI) && (_BMI < 30))
            {
                Console.ForegroundColor = ConsoleColor.DarkYellow;
                Console.WriteLine($"Your current BMI is {_BMI}");
            }
            else if ((30 <= _BMI) && (_BMI < 40))
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine($"Your current BMI is {_BMI}");
            }
            else if (_BMI <= 40)
            {
                Console.ForegroundColor = ConsoleColor.Magenta;
                Console.WriteLine($"Your current BMI is {_BMI}");
            }
            Console.ForegroundColor = ConsoleColor.White;
        }


        static double IsNumber(string measurement, string unit)
        {
            Console.WriteLine($"Give an your {measurement} in {unit}");
            string number = Console.ReadLine();
            bool b2 = Microsoft.VisualBasic.Information.IsNumeric(number);
            if (!b2)
            {
                Console.WriteLine($"This is not a {measurement}. Please give a decimal number");
                double number2 = IsNumber(measurement, unit);
                return number2;
            }
            else
            {
                double number1 = Convert.ToDouble(number);
                return number1;
            }
        }
    }
}
