using System;

class Program
{
    static void Main()
    {
        Console.Write(" R: ");
        double R = Convert.ToDouble(Console.ReadLine());

        const double pi = 3.14; 

        double L = 2 * pi * R;  
        double S = pi * R * R;   

        Console.WriteLine("d: " + L);
        Console.WriteLine("П: " + S);
    }
}