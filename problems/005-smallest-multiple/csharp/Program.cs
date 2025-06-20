using System;

public class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine(SmallestMultiple(20));
    }
    
    static long SmallestMultiple(int n)
    {
        long lcm = 1;
        
        for (int i = 2; i <= n; i++)
        {
            lcm = LCM(lcm, i);
        }
        
        return lcm;
    }

    static long LCM(long a, long b)
    {
        return a * b / GCD(a, b);
    }

    static long GCD(long a, long b)
    {
        while (b != 0)
        {
            long temp = b;
            b = a % b;
            a = temp;
        }
        return a;
    }
}
