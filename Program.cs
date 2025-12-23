using System;

class program
{
    static void Main()
    {
        int a = 4;
        int b = 5;
        int c = 5;
        int d = 5;


        if (a == b && b == c)
        {
            Console.WriteLine(4);
        }

        else if (a == b && b == d)
        {
            Console.WriteLine(3);
        }

        else if (a == c && c == d)
        {
            Console.WriteLine(2);
        }

        else if (b == c && c == d)
        {
            Console.WriteLine(1);
        }
        

        
    }
}