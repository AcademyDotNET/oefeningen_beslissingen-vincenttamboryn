using System;

namespace OhmCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Calculator();
        }
        static double[] LoadNumbers(string measurement1, string measurement2)
        {
            Console.WriteLine($"What is the {measurement1}");
            double value1 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine($"What is the {measurement2}");
            double value2 = Convert.ToDouble(Console.ReadLine());

            double [] values = { value1, value2 };
            return values;
        }

        static void Calculator()
        {
            Console.WriteLine("What would you like to calculate? Current, resistance or voltage?");

            string toCalculate = Console.ReadLine();
            double resistance;
            double current;
            double voltage;

            toCalculate = toCalculate.ToLower();

            switch (toCalculate)
            {
                case "current":

                    double[] voltageResistance = LoadNumbers("Voltage", "Resistance");
                    current = voltageResistance[0] / voltageResistance[1];
                    Console.WriteLine($"The current equals {current} A");
                    break;

                case "resistance":

                    double[] voltageCurrent = LoadNumbers("Voltage", "Current");
                    resistance = voltageCurrent[0] / voltageCurrent[1];
                    Console.WriteLine($"The resistance equals {resistance} Ohm");
                    break;

                case "voltage":

                    double[] resistanceCurrent = LoadNumbers("Resistance", "Current");
                    voltage = resistanceCurrent[0] * resistanceCurrent[1];
                    Console.WriteLine($"The voltage equals {voltage} V");
                    break;

                default:
                    Calculator();
                    break;

            }
        }
    }
}
