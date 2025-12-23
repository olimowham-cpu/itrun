using System;

class Program
{
    static void Main()
    {
        Console.Write(" A: ");
        int A = int.Parse(Console.ReadLine());

        Console.Write("B : ");
        int B = int.Parse(Console.ReadLine());

        for (int i = A; i <= B; i++)
        {
            int count = i - A + 1;
            for (int j = 0; j < count; j++)
            {
                Console.Write(i + " ");
            }
        }
    }
}