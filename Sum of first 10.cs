// See https://aka.ms/new-console-template for more information
using System;
namespace Program
{
    class Program
    {
        public static void Main(string[] args)
        {
            var sum = 0;
            for (var i = 1; i <= 10; i++)
            {
                sum += i;
            }
            Console.WriteLine($"This sum is :- { sum}");
        }
    }
}