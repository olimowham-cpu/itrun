using System;

class Program
{
    static void Main()
    {
        Console.Write("A: ");
        double A = Convert.ToDouble(Console.ReadLine());

        Console.Write("N : ");
        int N = Convert.ToInt32(Console.ReadLine());

        double r = 1;

        for (int i = 1; i <= N; i++)
        {
            r *= A;
            Console.WriteLine("A*A=" + i + " = " + r);
        }
    }
}