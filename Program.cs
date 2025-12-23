using System;

class program
{
    static void main()
    {
        int A = 5;
        int B = -3;
        int C = 0;

        bool num =
            (A > 0 && B <= 0 && C <= 0) ||
            (B > 0 && A <= 0 && C <= 0) ||
            (C > 0 && A <= 0 && B <= 0);

        Console.WriteLine(num);
    }
}