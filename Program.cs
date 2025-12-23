using System;

class Program
{
    static void Main()
    {
        Console.Write(" M: ");
        int M = Convert.ToInt32(Console.ReadLine());

        int a = M / 1000; 

        Console.WriteLine("toon: " + a);
    }
}