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
            int ctrS2 = 0;
            int ctrS1 = 0;
            int FSL = 0;
            int SSL = 0;
            if (S1 == null || S2 == null)
            {
                Console.Write("One or Both of Your Strings are Null, Comparison is Meaningless!");
                return;
            }
            FSL = S1.Length;
            SSL = S2.Length;
            if (FSL == 0 || SSL == 0)
            {
                Console.Write("One or Both of Your Strings are Null, Comparison is Meaningless!");
                return;
            }
            if (FSL > SSL)
            {
                Console.Write("Can't Find The First String In The Second One");
                return;
            }
            else
            {
                while ((ctrS2 < (SSL-1)))
                {
                    if (S1[ctrS1] == S2[ctrS2])
                    {
                        ctrS1++;
                        ctrS2++;
                        if (ctrS1 == FSL)
                        {
                            Console.Write("First String Was Found In The Second String");
                            break;
                        }
                    }
                    if (S1[ctrS1] != S2[ctrS2])
                    {
                        ctrS1 = 0;
                        ctrS2++;
                    }
                }
                if ((ctrS1 != FSL) && (ctrS2 == (SSL-1)))
                {
                    Console.Write("Can't Find The First String In The Second One");
                }
            }
        }
    }
}