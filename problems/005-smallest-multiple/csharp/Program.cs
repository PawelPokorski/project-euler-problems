using System;

public class Program
{
    public static void Main(string[] args)
    {
        long number = 1;
        
        int primesCount = 0;
        
        for(var i = 1; i <= 20; i++)
        {
            if(IsPrime(i))
            {
                primesCount++;
                number *= i;
            }
        }
        
        number *= 3*(primesCount);
        
        Console.WriteLine(number);
    }
    
    static bool IsPrime(long n)
    {
        if (n <= 1) return false;
        if (n == 2 || n == 3) return true;
        if (n % 2 == 0 || n % 3 == 0) return false;
    
        for (long i = 5; i * i <= n; i += 6)
        {
            if (n % i == 0 || n % (i + 2) == 0)
                return false;
        }
    
        return true;
    }
}
