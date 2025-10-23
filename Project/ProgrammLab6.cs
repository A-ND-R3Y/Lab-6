using System;

class Program
{
    static void Main()
    {
        Console.Write("Введіть перше число: ");
        int a = Convert.ToInt32(Console.ReadLine());

        Console.Write("Введіть друге число: ");
        int b = Convert.ToInt32(Console.ReadLine());

        int sum = a + b;
        Console.WriteLine($"Сума: {sum}");
    }
}
