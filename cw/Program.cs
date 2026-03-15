namespace cw;

class Program
{
    static void Main(string[] args)
    {
        var statisticsHelper = new StatisticsHelper();
        
        Console.WriteLine("Input a number:");
        
        var input = Console.ReadLine();

        var values = input.Split(' ')
            .Select(n => int.Parse(n.Trim()))
            .ToArray();
        
        statisticsHelper.CalculateAverage(values);
    }
}

class StatisticsHelper
{
    public void CalculateAverage(int[] values)
    {
        var sum = values.Sum();
        var mean = sum / values.Length;
        
        Console.WriteLine($"Average: {mean}");
    }
}