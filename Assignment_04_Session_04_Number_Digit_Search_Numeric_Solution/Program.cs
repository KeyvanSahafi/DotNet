using System;

namespace Test1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a Number: ");
            double Number = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter a Digit (0 to 9): ");
            char Digit = Convert.ToChar(Console.ReadLine());
            int rep = 0;
            foreach (char num in Number.ToString())
            {
                if (num == Digit)
                {
                    rep++;
                }
            }
            Console.WriteLine($"{Digit} Is Repeated {rep} Times in Your Input Number");
        }
     }
}