using System;

class Program
{
    static void Main(string[] args)
    {
        // Calling LINQ Query Syntax Example
        Console.WriteLine("LINQ Query Syntax Results:");

        Part5Exam.QuerySyntaxExample();

        // Calling LINQ Method Syntax Example
        Console.WriteLine("\nLINQ Method Syntax Results:");

        Part5Exam.MethodSyntaxExample();

        // Using the extension method
        string s = "Hello, extension methods!";

        int count = s.WordCount();
        
        Console.WriteLine($"\nWord Count: {count}");
    }
}