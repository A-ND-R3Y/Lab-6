using System;
using Lab6;

class Program
{
    static void Main()
    {
        Calculator calc = new Calculator();

        Console.Write("Введіть перше число: ");
        int a = Convert.ToInt32(Console.ReadLine());

        Console.Write("Введіть друге число: ");
        int b = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("\nОберіть операцію:");
        Console.WriteLine("1 - Додавання");
        Console.WriteLine("2 - Віднімання");
        Console.WriteLine("3 - Множення");
        Console.WriteLine("4 - Ділення");
        Console.Write("Ваш вибір: ");
        int choice = Convert.ToInt32(Console.ReadLine());

        double result = choice switch
        {
            1 => calc.Add(a, b),
            2 => calc.Subtract(a, b),
            3 => calc.Multiply(a, b),
            4 => calc.Divide(a, b),
            _ => double.NaN
        };

        Console.WriteLine($"\nРезультат: {result}");
    }
}
