using System;

namespace MyApp
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Console.Write("Enter a String: ");
            string word = System.Console.ReadLine();
            System.Console.WriteLine(Reverse(word));
        }
        public static string Reverse(string str)
        {
            int ctr = str.Length - 1;
            if (ctr >= 0)
                return str[ctr] + Reverse(str.Substring(0, ctr));
            else
                return str;
        }
    }
}