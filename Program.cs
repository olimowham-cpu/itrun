using System;

class Program
{
    static void Main()
    {

        int a = 40;
        int b = 5;
        int c = 60;
        int n;
        if (a < b && a<c)
        {
            n = b + c;
        }
        else if (b < a && b < c)
        {
            n = c + a;
        }
        else
        {
            n = a + b;
            
        }

        Console.WriteLine(n);

    }
}