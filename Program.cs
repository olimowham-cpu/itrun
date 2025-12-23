using System;

class Program
{
    static void Main()
    {
        Console.Write("a: ");
        double a = Convert.ToDouble(Console.ReadLine());

        Console.Write(" b: ");
        double b = Convert.ToDouble(Console.ReadLine());

        double average = (a + b) / 2;

        Console.WriteLine("= " + average);
    }
}