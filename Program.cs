using System;

namespace Factorial
{
    class Program
    {
        static void Main(string[] args)
        {
            int i, factorial = 1, number;
            Console.Write("Enter a Number: ");
            number = int.Parse(Console.ReadLine());
            for (i = 1; i <= number; i++)
            {
                factorial = factorial * i;
            }
            Console.Write("Factorial of the Number is: " + factorial);
        
        }

    }
}
