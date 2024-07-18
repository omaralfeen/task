using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace day10
{
    class BMICalculator
    {
        public int Height { get; set; }
        public int Weight { get; set; }
        public double Bmi { get; private set; }

        public Stack<double> bmiStack = new Stack<double>();

        public BMICalculator(int height, int weight)
        {
            Height = height;
            Weight = weight;
            Bmi = CalculateBMI(Height, Weight);
        }

        public double CalculateBMI(int h, int w)
        {
            double heightMeters = Height / 100.0;
            Bmi = w / (heightMeters * heightMeters);
            bmiStack.Push(Bmi);
            return Bmi;
        }

        public void DisplayCurrentBMI()
        {
            Console.WriteLine($"BMI current: {Bmi:f2}");
        }

        public void DisplayBMICalculations()
        {
            Console.WriteLine("bmi in stack");
            foreach (var bmi in bmiStack)
            {
                Console.WriteLine($" {bmi:f2}");
            }
        }
    }
}
