using System;

class Program
{
    static void Main()
    {
        
        int day = int.Parse(Console.ReadLine());

        string Name;

        switch (day)
        {
            case 1:
                Name = "poni"; 
                break;
            case 2:
                Name = "vtorn";    
                break;
            case 3:
                Name = "sreda";       
                break;
            case 4:
                Name = "chetverg";    
                break;
            case 5:
                Name = "5nitsa";   
                break;
            case 6:
                Name = "subbota";   
                break;
            case 7:
                Name = "voskresenie";
                break;
            default:
                Name = "error";
                break;
          
        }
        

        Console.WriteLine("  " + Name);
    }
}