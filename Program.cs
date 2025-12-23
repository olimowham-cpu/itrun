using System;

class Program
{
    static void Main()
    {
        Console.Write("d: ");
        double d = Convert.ToDouble(Console.ReadLine());

         double pi = 3.14;  
        double a = pi * d;       
        Console.WriteLine("= " + a);
    }
}