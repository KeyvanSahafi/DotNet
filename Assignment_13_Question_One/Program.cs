using System;
using System.Collections.Generic;

namespace MyApp
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> Words = new List<string>(){"Parviz", "Iria", "Asghar", "parham", "Javad", "parvaneh", "amir", "ziba", "paniz","PArdis", "Peyman", "Pedram"};
            Words.Where(x=>x.Substring(0,2).ToLower() != "pa").ToList().ForEach(x=>System.Console.WriteLine(x));
        }
    }
}