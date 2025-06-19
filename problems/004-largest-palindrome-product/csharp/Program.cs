using System;

public class Program
{
    static void Main(string[] args)
    {
        var biggestPalindrome = 0;

        for (int i = 999; i >= 100; i--)
        {
            for (int j = 999; j >= 100; j--)
            {
                if (IsPalindrome(i * j) && i * j > biggestPalindrome)
                {
                    biggestPalindrome = i * j;
                }
            }
        }

        Console.WriteLine(biggestPalindrome);
    }

    public static bool IsPalindrome(int number)
    {
        var numberString = number.ToString();
        var reversedString = new string([.. numberString.Reverse()]);
        return numberString.Equals(reversedString);
    }
}
