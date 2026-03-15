namespace cw;

class Program
{
    static void Main(string[] args)
    {
        var statisticsHelper = new StatisticsHelper();
        
        Console.WriteLine("Input a number:");
        
        var input = Console.ReadLine();
        
        statisticsHelper.InputDebug(input);
        
        
    }
}

class StatisticsHelper
{
    public void InputDebug(string input)
    {
        if (input.Length > 0)
        {
            Console.Write("Input: " + input); 
        }
        else
        { 
            throw new ArgumentException("No user input");
        }
    }
}