using System;
using System.Collections.Generic;

namespace MyApp
{
    class Program
    {
        static void Main(string[] args)
        {
                            // // ** (Test Cases) **// //

            // List<string> Lst1 = new List<string>(){"amir", "abbas", "akbar", "saeed", "hamid", "nadi"};
            // List<string> Lst2 = new List<string>(){"amir", "abbas", "akbar", "saeed", "hamid", "Nadi"};
            // List<bool> Lst3 = new List<bool>(){true, false, true, false, false};
            // List<bool> Lst4 = new List<bool>(){false, true, true, false, true};
            // List<int> Lst5 = new List<int>(){1, 5, 6, 7, 2, 8};
            // List<int> Lst6 = new List<int>(){8, 6, 1, 7, 5, 2};
            // System.Console.WriteLine(IsEquals(Lst1, Lst2));
            // System.Console.WriteLine(IsEquals(Lst3, Lst4));
            // System.Console.WriteLine(IsEquals(Lst5, Lst6));
        }
        public static bool IsEquals<T>(List<T> lstF, List<T> lstL)
        {
            int count = 0;
            foreach (dynamic item in lstF)
            {
                if (lstL.Contains(item) == true && (lstL.Where(x => x == item).ToList().Count() == lstF.Where(x => x == item).ToList().Count()))
                    count++;
            }
            if((count == lstF.Count()) && (lstF.Except(lstL).Count() == 0) && (lstF.Count == lstL.Count))
                return true;
            else
                return false;
        }
    }
}