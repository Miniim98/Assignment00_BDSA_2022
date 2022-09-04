namespace MyApp;

public class Program
{
    
    static void Main(string[] args) 
    {
        HandleUserInteraction();
    }

    private static void HandleUserInteraction()
    {
        Console.WriteLine("Welcome to my leapyear check program!");
        while (true)
        {
           Console.WriteLine("\n[1] check a year \n[2] exit"); 
           var answer = Console.ReadLine();
           if (answer == "1")
           {
            Console.WriteLine("Please type the year that you want to check and press enter!");
            userInterfaceLeapYear();
           }
           else if (answer == "2"){break;}
           else
           {
            Console.WriteLine("Please input a valid option!");
           }
        }
    }

    public static void userInterfaceLeapYear()
    {
        var input = Console.ReadLine();
        if (ErrorChecking(input))
        {
            var year = int.Parse(input);
            if (IsLeapYear(year))
            {
                Console.WriteLine("yay!");
                return;
            }
            Console.WriteLine("nay!");
        }
        
        
    }
    public static bool IsLeapYear(int year) 
    {
        if (year % 4 == 0) 
        {
            if (year % 100 == 0)
            {
                return (year % 400 == 0);
            }
            return true;
        }
        return false;
    }

    private static bool ErrorChecking(string input)
    {
        int year;
        try 
        {
            year = int.Parse(input);
        } 
        catch (Exception)
        {
           Console.WriteLine("Please input an integer!");
           return false; 
        }

        if (year < 1582)
        {
            Console.WriteLine("Please input a year equal or higher than 1582");
            return false;
        }
        return true;
    }
}

