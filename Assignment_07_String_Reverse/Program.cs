using System;

namespace Reverse
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Console.Write("Enter a String: ");
            string word = System.Console.ReadLine();
            System.Console.WriteLine($"Reversed string is: {Reverse(word)}"); 
        }
        public static string Reverse(string str)
        {
            string rev = "";  
            int ctr = str.Length - 1;
            while (ctr >= 0)  
            {  
                rev = rev + str[ctr];
                ctr--;  
            }  
            return rev;  
        }
    }
}