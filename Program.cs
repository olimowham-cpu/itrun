using System;

class Program
{
    static void Main()
    {
        int a = int.Parse(Console.ReadLine());
        int b = int.Parse(Console.ReadLine());
        int c = int.Parse(Console.ReadLine());
        int d = 0;
        if (a <0)
        {
            d += 1;
       
        }
         if (b< 0)
        {
            
            d += 1;
        }
        if (c < 0)
        {
            
            d += 1;
        }

        Console.WriteLine(d);
        
}
}