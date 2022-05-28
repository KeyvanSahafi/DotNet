using System;

namespace Test1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Please Enter A Number: ");
            int inputnumber = Convert.ToInt32(Console.ReadLine());
            int sum = 0;
            if (inputnumber <= 0)
                {
                  Console.WriteLine("Wrong Input - Please Enter a positive number");
                  return;
                }
            if (inputnumber % 2 == 0)
                {
                    inputnumber--;
                }
                while (inputnumber > 0)
                {
                    sum = sum + inputnumber;
                    inputnumber = inputnumber -2;
                }
                Console.WriteLine($"Sum of Odd number up to your input is: {sum}");
        }
    }
}