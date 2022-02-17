using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public class csharpExercise
{
    static void Main(string[] args)
    {

        int i, num;

        //Reading number
        Console.WriteLine("Enter number to print table: ");
        num = Convert.ToInt32(Console.ReadLine());

        for (i = 1; i <= 10; i++)
        {
            //Printing table of number entered by user            
            Console.WriteLine(+ num * i);
        }
        Console.ReadLine();
    }
}