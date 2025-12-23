using System;

class program
{
    static void main()
    {


        int A = 8;
        int B = 5;
        int C = 2;

        bool result = (A < B && B < C) || (C < B && B < A);

        Console.WriteLine(result);
    }
}