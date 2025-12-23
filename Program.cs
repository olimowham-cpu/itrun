using System;

class Program
{
    static void Main()
    {
        int x = int.Parse(Console.ReadLine());
        if (x > 0)
        {
            Console.WriteLine(x+1);
        }
        else
        {
            Console.WriteLine(x-2);
        }
    }
}