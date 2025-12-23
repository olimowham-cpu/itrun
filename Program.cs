using System;

class Program
{
    static void Main()
    {
        
        int un =int.Parse(Console.ReadLine());

        Console.Write("dlina: ");
        double len = int.Parse(Console.ReadLine());

        double leng;

        switch (un)
        {
            case 1:
                leng = len / 10;
                break;
            case 2: 
                leng = len * 1000;
                break;
            case 3: 
                leng = len;
                break;
            case 4:
                leng = len / 1000;
                break;
            case 5: 
                leng = len / 100;
                break;
            default:
                Console.WriteLine(" error");
                return;
        }

        Console.WriteLine("Длина: " + leng);
    }
} 