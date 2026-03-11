namespace cw;

class Program
{
    static void Main(string[] args)
    {
        int number = 10;
        char spc = ' ';
        
        for (int i = 1; i <= number; i++)
        {
            for (int j = 20; j >= 0; j-=i)
            {
                Console.Write(spc);
            }
            Console.WriteLine(i);
        }
    }
}