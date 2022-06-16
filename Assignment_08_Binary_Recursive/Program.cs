using System;

namespace MyApp
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Console.Write("Enter a Number In 10 Base: ");
            int number = Convert.ToInt32(System.Console.ReadLine());
            System.Console.WriteLine($"Binary Equivalent of {number} is: {ToBinary(number)}");
        }
        public static double ToBinary(int number)
        {
            if (number >= 2)
                return (10 * ToBinary(number / 2) + number % 2);
            else
                return 1;
        }
    }
}