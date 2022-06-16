using System;

namespace MyApp
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Console.Write("Enter Your Base Number (Integer): ");
            int number = Convert.ToInt32(System.Console.ReadLine());
            System.Console.Write("Enter Your Power Number (Integer): ");
            int power = Convert.ToInt32(System.Console.ReadLine());
            System.Console.WriteLine(Power(number, power)); 
        }
        public static double Power(int number, int power)
        {
            if (power > 0)
                return number * Power(number, power - 1);
            else
                return 1;
        }
    }
}