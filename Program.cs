using System;

class program
{
    static void Main()
    {
        int A = 55;
        int B = 5;
        int C = 4;

        bool result = (A < B && B < C) || (C < B && B < A);

        Console.WriteLine(result);

    }
}