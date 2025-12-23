using System;

class Program

{
    static void Main()
    {
        int a = int.Parse(Console.ReadLine());
        int b = int.Parse(Console.ReadLine());
        int c = int.Parse(Console.ReadLine());
        if (a >b)
        {
            Console.WriteLine(a);
        }

        if (b >a)
        {
            Console.WriteLine(b);
        }

        if (c <b)
        {
            Console.WriteLine(c);
        }
            

    }
}