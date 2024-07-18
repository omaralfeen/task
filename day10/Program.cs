

using System;
using System.Collections.Generic;

namespace day10
{
   
    class Program
    {
        static void Main()

        {
            Console.WriteLine("enter height:");
            int h = int.Parse(Console.ReadLine());

            Console.WriteLine("enter weidth:");
            int w = int.Parse(Console.ReadLine());

            BMICalculator calculator = new BMICalculator(h, w);

            Console.WriteLine("enter 0 for bmi or enter 1 for bmi in stack:");
            int choice = int.Parse(Console.ReadLine());

            if (choice == 0)
            {
                calculator.DisplayCurrentBMI();
            }
            else if (choice == 1)
            {
                calculator.DisplayBMICalculations();
            }
            else
            {
                Console.WriteLine("Invalid choice.");
            }
            Console.ReadLine();
            //----------------------------------------------------------------------------------------
            Calculator<int> intCalculator = new Calculator<int>();
            Console.WriteLine("enter first number");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("enter second number");
            int b = int.Parse(Console.ReadLine());
            Console.WriteLine("enter opearator");
            string z = (Console.ReadLine());
            if (z == "+")
            {
                Console.WriteLine($"Addition: {intCalculator.Add(a,b)}");
            }
            else if (z == "-")
            {
                Console.WriteLine($"Subtraction: {intCalculator.Subtract(a,b)}");
            }
            else if (z == "*")
            {
                Console.WriteLine($"Multiplication: {intCalculator.Multiply(a,b)}");
            }
            else if (z == "/")
            {
                Console.WriteLine($"Division: {intCalculator.Divide(a,b)}");
            }
            



        }
    }
}






