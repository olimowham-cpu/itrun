using System ;

class program
{
    static void Main()
    {
        int a = 5;
        int b = 4;
        int c = 4;
        if (a == b)
        {
            Console.WriteLine(c);
        }

        else if (a == c)
        {
            Console.WriteLine(b);
        }
        else if (b == c)
        {
            Console.WriteLine(a);
        }
        
    }
}
