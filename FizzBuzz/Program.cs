using System;

public class Program
{
    public static void Main()
    {
        // https://po.kattis.com/help/csharp
        string input;
        while ((input = Console.ReadLine()) != null)
        {
            string[] split = input.Split(new char[] { ' ' }, StringSplitOptions.None);
            var x = int.Parse(split[0]);
            var y = int.Parse(split[1]);
            var n = int.Parse(split[2]);
            for (int i = 1; i <= n; i++)
            {
                if (i % x == 0)
                {
                    if (i % y == 0)
                    {
                        Console.WriteLine("FizzBuzz");
                    }
                    else
                    {
                        Console.WriteLine("Fizz");
                    }
                }
                else if (i % y == 0)
                {
                    Console.WriteLine("Buzz");
                }
                else
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
}