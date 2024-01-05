//LINQ
using System;
using System.Linq;

public class Part5Exam
{
    public static void QuerySyntaxExample()
    {
        int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
        var largeNumbers = from num in numbers
                           where num > 5
                           select num;

        foreach (var num in largeNumbers)
        {
            Console.WriteLine(num);
        }
    }

    public static void MethodSyntaxExample()
    {
        int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
        var largeNumbers = numbers.Where(num => num > 5);

        foreach (var num in largeNumbers)
        {
            Console.WriteLine(num);
        }
    }
}


public static class StringExtensions
{
    public static int WordCount(this string str)
    {
        return str.Split(new char[] { ' ', '.', '?' }, StringSplitOptions.RemoveEmptyEntries).Length;
    }
}
