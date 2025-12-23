using System;

class program
{
    static void Main()
    {
        int a = int.Parse(Console.ReadLine());
        int b = int.Parse((Console.ReadLine()));
        int c = 0;

        if (a < b)
        {
            Console.WriteLine(a);
            Console.WriteLine(b);
        }

        if (b < a)
        {
            Console.WriteLine(b);
            Console.WriteLine(a);
        }
        else
        {
            Console.WriteLine("oshipka");
        }
    }
}