using System;
class Program
{
    static void Main()
    {
        Console.WriteLine("Введіть перше число: ");
        double num1 = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Введіть друге число: ");
        double num2 = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Введіть третє число: ");
        double num3 = Convert.ToDouble(Console.ReadLine());

        double max = FindMax(num1, num2, num3);
        Console.WriteLine($"Найбільше число: {max}");
    }
    static double FindMax(double a, double b, double c)
    {
        return Math.Max(Math.Max(a, b), c);
    }
}