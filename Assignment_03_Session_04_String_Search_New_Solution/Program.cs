using System;

namespace Test1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter Your First String (S1): ");
            string? S1 = Console.ReadLine();
            Console.Write("Enter Your Second String (S2): ");
            string? S2 = Console.ReadLine();
            int ctr = 0;
            if (S1 == null || S2 == null || S1.Length == 0 || S2.Length == 0)
            {
                Console.Write("One or Both of Your Strings are Null, Comparison is Meaningless!");
                return;
            }
            if (S1.Length > S2.Length)
            {
                Console.Write("Can't Find The First String In The Second One");
                return;
            }
            for (ctr = 0; ctr <= (S2.Length - S1.Length); ctr++)
            {
                if (S2.Substring(ctr, S1.Length) == S1)
                {
                    Console.Write("First String Was Found In The Second String");
                    break;
                }
            }
            if (ctr == S2.Length - S1.Length + 1)
                Console.Write("Can't Find The First String In The Second One");
        }
    }
}