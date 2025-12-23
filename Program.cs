using System;

class Program
{
    static void Main()
    {
        int a = int.Parse(Console.ReadLine());
        if (a >0)
        {
            Console.WriteLine(a+1);
        }

        else if (a <= 0)
        {
            Console.WriteLine(a+2);
        }
        else if(a==0)
        {
            Console.WriteLine(10);
        }
        else
        {
            Console.WriteLine(a==10);
        }
    }
}