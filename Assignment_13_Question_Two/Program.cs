using System;
using System.Collections.Generic;

namespace MyApp
{
    class Program
    {
        static void Main(string[] args)
        {
                            // // ** (Test Cases) **// //

            // List<string> Lst1 = new List<string>(){"amir", "abbas", "akbar", "saeed", "hamid"};
            // List<string> Lst2 = new List<string>(){"amir", "abbas", "akbar", "saeed", "hadi"};
            // List<bool> Lst3 = new List<bool>(){true, false, true, false};
            // List<bool> Lst4 = new List<bool>(){false, true, true, false};
            // List<int> Lst5 = new List<int>(){1, 5, 6, 7, 8, 8};
            // List<int> Lst6 = new List<int>(){8, 6, 1, 7, 5};
            // System.Console.WriteLine(IsEquals(Lst1, Lst2));
            // System.Console.WriteLine(IsEquals(Lst3, Lst4));
            // System.Console.WriteLine(IsEquals(Lst5, Lst6));
        }
        public static bool IsEquals<T>(List<T> lstF, List<T> lstL)
        {
            List<T> union = lstF.Union(lstL).ToList();
            List<T> intersect = lstF.Intersect(lstL).ToList();
            List<T> except = union.Except(intersect).ToList();
            if((union.Count() == intersect.Count()) && (union.Except(intersect).Count() == 0) && (lstF.Count == lstL.Count))
                return true;
            else
                return false;
        }
    }
}