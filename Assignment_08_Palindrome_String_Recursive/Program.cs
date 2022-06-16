using System;

namespace MyApp
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Console.Write("Enter Your String to Check if it is palindrome: ");
            string str = System.Console.ReadLine();
            System.Console.WriteLine(Palindrome(str));
        }
        public static bool Palindrome(string str)
        {
            if (str.Length < 2)
                return true;
            else
            {
                if (str[0] == str[str.Length - 1])
                    return Palindrome (str.Substring(1, str.Length - 2));
                else
                    return false;
            }
        }
    }
}