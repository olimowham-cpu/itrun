using System;

class Program
{
    static void Main()
    {
        Console.Write(" a: ");
        double a = Convert.ToDouble(Console.ReadLine());

        Console.Write(" b: ");
        double b = Convert.ToDouble(Console.ReadLine());

        Console.Write(" c: ");
        double c = Convert.ToDouble(Console.ReadLine());

        double V = a * b * c;               
        double S = 2 * (a * b + b * c + a * c);

        Console.WriteLine("= " + V);
        Console.WriteLine("= " + S);
    }
}