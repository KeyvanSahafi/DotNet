using System;

namespace Test1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Case-Sensitive 
            Console.Write("Enter Your First String (S1): ");
            string? S1 = Console.ReadLine();
            Console.Write("Enter Your Second String (S2): ");
            string? S2 = Console.ReadLine();
            if (S1 == null || S2 == null)
            {
                Console.Write("One or Both of Your Strings are Null, Comparison is Meanenigless!");
                return;
            }
            if (S2.Contains(S1))
            {
                Console.Write("Second String Contains The First String");
            }
            else
            {
                Console.Write("First String Is Not Included In The Second String");
            }
        }
    }
}