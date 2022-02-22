// See https://aka.ms/new-console-template for more informatio
using System;
public class Factorial
{
    public static void Main(String[] args)
    {
        int i, fact = 1, n;
        Console.WriteLine("Enter Any Number");
        n = int.Parse(Console.ReadLine());
        for (i =1; i <= n; i++)
        {
            fact = fact * i;

        }
        Console.WriteLine("Factorial of"+n+"is"+fact);
    }
}