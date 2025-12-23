using System;

class Program
{
    static void Main()
    {
        Console.Write("L: ");
        int L = Convert.ToInt32(Console.ReadLine());

        int f= L / 100; 

        Console.WriteLine(": " + f);
    }
}