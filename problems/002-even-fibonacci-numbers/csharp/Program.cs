using System;
using System.Collections.Generic;

public class Program
{
    static void Main(string[] args)
    {
        var list = Fibonacci(4000000);

        Console.WriteLine(EvenSum(list));
    }

    static List<int> Fibonacci(int maxValue)
    {
        List<int> fiboList = [1, 2];

        while (true)
        {
            int currentElement = fiboList[^1] + fiboList[^2];
            if (currentElement >= maxValue) break;
            fiboList.Add(currentElement);
        }

        return fiboList;
    }

    static int EvenSum(List<int> list)
    {
        int sum = 0;

        foreach (int el in list)
        {
            if (el % 2 == 0)
                sum += el;
        }

        return sum;
    }
}
