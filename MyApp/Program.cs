namespace MyApp;

public class Program
{
    
    static void Main(String []args) 
    {
        Console.WriteLine("Please type the year that you want to check");
        userInterfaceLeapYear();
    }

    public static void userInterfaceLeapYear()
    {
        var input = Console.ReadLine();
        var year = int.Parse(input);
        if (IsLeapYear(year) && input != null)
        {
            Console.WriteLine("yay");
            return;
        }
        Console.WriteLine("nay");
        
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
}

