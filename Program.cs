using System;

class Program
{
    static void Main()
    {
        Console.Write(" A: ");
        int A = Convert.ToInt32(Console.ReadLine());

        Console.Write(" B: ");
        int B = Convert.ToInt32(Console.ReadLine());

        Console.Write(" C: ");
        int C = Convert.ToInt32(Console.ReadLine());

        int temp = A;
        A = B;
        B = C;
        C = temp;

        Console.WriteLine("new:");
        Console.WriteLine("A = " + A);
        Console.WriteLine("B = " + B);
        Console.WriteLine("C = " + C);
    }
}