using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EvenOrOddNumberChecker
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter an Integer: ");
            string input = Console.ReadLine();
            DetermineEvenOrOdd(input); 
        }
        static void DetermineEvenOrOdd(string input)
        {
            //try to parse the input as an integer
            if (int.TryParse(input, out int number))
            {
                //check if the number is even or odd
                if (number % 2 == 0)
                {
                    Console.WriteLine("Even Number");
                }
                else
                {
                    Console.WriteLine("Odd Number");
                }
            }
            else
            {
                Console.WriteLine("Invalid input. Enter a valid integer."); 
            }
        }
    }
}
