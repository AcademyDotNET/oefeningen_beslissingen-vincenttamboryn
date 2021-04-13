using System;

namespace BMI_met_enum
{
    class Program
    {
        enum bodyTypes {Underweight = 1,NormalWeight ,Overweight, Obese, SeriouslyObese }
        static void Main(string[] args)
        {
            double height = IsNumber("height", "meters", 0, 3);
            double weight = IsNumber("weight", "kilograms", 0, 500);
            double _BMI = Math.Round(weight / (Math.Pow(height, 2)), 2);
            if (_BMI < 18.5)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine($"Your current BMI is {_BMI}");
                Console.WriteLine($"Your bodytype is {(bodyTypes)1}");
            }
            else if ((18.5 <= _BMI) && (_BMI < 25))
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine($"Your current BMI is {_BMI}");
                Console.WriteLine($"Your bodytype is {(bodyTypes)2}");
            }
            else if ((25 <= _BMI) && (_BMI < 30))
            {
                Console.ForegroundColor = ConsoleColor.DarkYellow;
                Console.WriteLine($"Your current BMI is {_BMI}");
                Console.WriteLine($"Your bodytype is {(bodyTypes)3}");
            }
            else if ((30 <= _BMI) && (_BMI < 40))
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine($"Your current BMI is {_BMI}");
                Console.WriteLine($"Your bodytype is {(bodyTypes)4}");
            }
            else if (_BMI <= 40)
            {
                Console.ForegroundColor = ConsoleColor.Magenta;
                Console.WriteLine($"Your current BMI is {_BMI}");
                Console.WriteLine($"Your bodytype is {(bodyTypes)5}");
            }
            Console.ForegroundColor = ConsoleColor.White;
        }


        static double IsNumber(string measurement, string unit, double min, double max)
        {
            
            Console.WriteLine($"Give an your {measurement} in {unit}.");
            string number = Console.ReadLine();
            bool b2 = Microsoft.VisualBasic.Information.IsNumeric(number);
            if (!b2)
            {
                Console.WriteLine($"This is not a {measurement}. Please give a decimal number.");
                double number1 = IsNumber(measurement, unit, min, max);
                return number1;
            }
            else
            {
                double number2 = Convert.ToDouble(number);
                if (number2 < min || number2 > max)
                {
                    Console.WriteLine($"This {measurement} is too high or too low.");
                    double number3 = IsNumber(measurement, unit, min, max);
                    return number3;
                }
                else
                {
                    return number2;
                }
            }
        }
    }
}
