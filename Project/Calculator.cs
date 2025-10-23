using System;

namespace Lab6
{
    public class Calculator
    {
        public int Add(int a, int b)
        {
            return a + b;
        }

        public int Subtract(int a, int b)
        {
            return a - b;
        }

        public int Multiply(int a, int b)
        {
            return a * b;
        }

        public double Divide(int a, int b)
        {
            if (b == 0)
            {
                Console.WriteLine("Ділення на нуль неможливе!");
                return double.NaN;
            }
            return (double)a / b;
        }
    }
}
