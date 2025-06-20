using System;

public class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine(SquareOfSum(100) - SumOfSquares(100));
    }
    
    static long SumOfSquares(int n)
    {
        long sum = 0;
        
        for(int i = 1; i <= n; i++)
        {
            sum += i * i;
        }
        
        return sum;
    }
    
    static long SquareOfSum(int n)
    {
        int sum = 0;
        
        for(int i = 1; i <= n; i++)
        {
            sum += i;
        }
        
        long square = sum * sum;
        
        return square;
    }
}
