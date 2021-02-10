using System;

namespace Calculator
{
    class MainProgram
    {
        static void Main(string[] args)
        {
            var calculator = new Calculator();
            double no1 = 0, no2 = 0, no3 = 0, Result;

            Console.WriteLine("Choose the first number: ");
            no1 = double.Parse(Console.ReadLine());
            Console.WriteLine("Choose the second number: ");
            no2 = double.Parse(Console.ReadLine());

            Console.WriteLine("Choose an option from the following list: ");
            Console.WriteLine("\ta - Add");
            Console.WriteLine("\ts - Subtract");
            Console.WriteLine("\tm - Multiply");
            Console.WriteLine("\td - Divide");
            Console.WriteLine("\tp - Power");

            switch (Console.ReadLine())
            {
                case "a":
                    Result = calculator.Add(no1, no2);
                    Console.WriteLine($"{no1} + {no2} = {Result}");
                    break;
                case "s":
                    Result = calculator.Subtract(no1, no2);
                    Console.WriteLine($"{no1} - {no2} = {Result}");
                    break;
                case "m":
                    Result = calculator.Multiply(no1, no2);
                    Console.WriteLine($"{no1} x {no2} = {Result}");
                    break;
                case "d":
                    Result = calculator.Divide(no1, no2);
                    Console.WriteLine($"{no1} / {no2} = {Result}");
                    break;
                case "p":
                    Result = calculator.Power(no1, no2);
                    Console.WriteLine($"{no1} ^ {no2} = {Result}");
                    break;
                default:
                    break;
            }

            bool quit = false;

            while (quit == false)
            {
                Console.Write("Choose a new number: ");
                no3 = double.Parse(Console.ReadLine());

                Console.WriteLine("Choose an option from the following list: ");
                Console.WriteLine("\ta - Add");
                Console.WriteLine("\ts - Subtract");
                Console.WriteLine("\tm - Multiply");
                Console.WriteLine("\td - Divide");
                Console.WriteLine("\tp - Power");
                Console.WriteLine("\tc - Clear");
                Console.WriteLine("\tq - Quit");

                switch (Console.ReadLine())
                {
                    case "a":
                        Result = calculator.Add(no3);
                        Console.WriteLine($"{calculator.Accumulator} + {no3} = {Result}");
                        break;
                    case "s":
                        Result = calculator.Subtract(no3);
                        Console.WriteLine($"{calculator.Accumulator} - {no3} = {Result}");
                        break;
                    case "m":
                        Result = calculator.Multiply(no3);
                        Console.WriteLine($"{calculator.Accumulator} x {no3} = {Result}");
                        break;
                    case "d":
                        //Result = calculator.Divide(no3);
                        //Console.WriteLine($"{calculator.Accumulator} / {no3} = {Result}");
                        break;
                    case "p":
                        Result = calculator.Power(no3);
                        Console.WriteLine($"{calculator.Accumulator} ^ {no3} = {Result}");
                        break;
                    case "c":
                        calculator.Clear();
                        break;
                    case "q":
                        quit = true;
                        break;
                    default:
                        break;
                }
            }
        }
    }
}
