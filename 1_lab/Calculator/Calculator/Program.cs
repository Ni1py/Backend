using System;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            bool endApp = false;
            Console.WriteLine("Console Calculator in C#");
            Console.WriteLine("------------------------");

            while (!endApp)
            {
                string input1 = "";
                string input2 = "";
                double result = 0;

                Console.Write("Enter the first number: ");
                input1 = Console.ReadLine();

                double convertedNumber1 = 0;
                while (!double.TryParse(input1, out convertedNumber1))
                {
                    Console.Write("Incorrect input! Enter a numeric value: ");
                    input1 = Console.ReadLine();
                }

                Console.Write("Enter the second number: ");
                input2 = Console.ReadLine();

                double convertedNumber2 = 0;
                while (!double.TryParse(input2, out convertedNumber2))
                {
                    Console.Write("Incorrect input! Enter a numeric value: ");
                    input2 = Console.ReadLine();
                }

                Console.WriteLine("Select an operation from the list:");
                Console.WriteLine("\t+ - Add");
                Console.WriteLine("\t- - Subtract");
                Console.WriteLine("\t* - Multiply");
                Console.WriteLine("\t/ - Divide");
                Console.Write("Enter the operation: ");
                string ch = Console.ReadLine();

                result = Calculator.PerformCalculation(convertedNumber1, convertedNumber2, ch);
                if (double.IsNaN(result))
                {
                    Console.WriteLine("This operation will result in a mathematical error.");
                }
                else Console.WriteLine("Your result: {0:0.##}", result);

                Console.WriteLine("------------------------\n");

                Console.Write("Enter 'c' to close the program, or enter any other key to continue: ");
                if (Console.ReadLine() == "c") endApp = true;

                Console.WriteLine();
            }

            return;
        }
    }
}
