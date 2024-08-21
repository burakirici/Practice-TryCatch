using System;
using System.Net.WebSockets;


class Program
{
    public static void Main(string[] args)
    {
        try
        {
            Console.WriteLine("Enter a number : ");
            string input = Console.ReadLine();

            int number = Convert.ToInt32(input);

            int result;
            result = number * number;
            Console.WriteLine("Sqaure of the Number: " + result);

        }

        catch (FormatException ex)
        {
            Console.WriteLine("Invalid Entry! Please enter a number");
        }
    }
}