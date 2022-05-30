using System;

namespace Test1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a Number: ");
            string Number = Console.ReadLine();
            Console.Write("Enter a Digit (0 to 9): ");
            string Digit = Console.ReadLine();
            int rep = Search(Digit, Number);
            Console.WriteLine($"{Digit} Is Repeated {rep} Times in Your Input Number");
        }
        public static int Search(string S1, string S2)
        {
            int ctr = 0;
            int rep = 0;
            int Val = 0;
            if (S1 == null || S2 == null || S1.Length == 0 || S2.Length == 0)
            {
                return 0;
            }
            while (!(('1') <= S2[Val] && S2[Val] <= ('9')) && S2[Val] != '.')
            {
                Val++;
                if (S2[Val] == '.' && S1 =="0")
                {
                    rep = 1;
                }
            }
            for (ctr = Val; ctr <= (S2.Length - S1.Length); ctr++)
            {
                if (S2.Substring(ctr, S1.Length) == S1)
                {
                    rep++;
                }
            }
            return rep;
        }
    }
}