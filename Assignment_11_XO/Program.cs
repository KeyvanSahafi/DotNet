using System;
using System.Collections.Generic;
namespace XO
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> choices = new List<string>(){"1" , "2", "3", "4", "5", "6", "7", "8", "9"};
            string OX = "OX";
            List<int> availablenumbers = new List<int>(){1, 2, 3, 4, 5, 6, 7, 8, 9};
            int player = 1;
            int count = 0;
            System.Console.WriteLine();
            System.Console.WriteLine("Welcome To XO \n");
            while (1 == 1)
            {
                System.Console.WriteLine("Player1:X  and  Player2:O \n");
                System.Console.WriteLine($"Player {player} Turn \n \n");
                PrintMap(choices);
                int choice = Convert.ToInt32(System.Console.ReadLine());
                System.Console.WriteLine();
                if (choice == null || choice < 1 || choice > 9)
                    System.Console.WriteLine("Wrong Input, Enter A Number Between 1-9");
                else if (availablenumbers.Contains(choice) == false && (choice > 0 && choice < 10))
                    System.Console.WriteLine("Wrong Input, Number Already Picked");
                else
                {
                    availablenumbers.Remove(choice);
                    choices = choices.Select(x => x.Replace($"{choice}", OX.Substring(player %2 , 1))).ToList();
                    count++;
                    player++;
                    if (player % 2 == 1)
                        player = 1;
                    else
                        player = 2;
                }
                if (CheckWin(choices) == 0)
                    continue;
                else if (CheckWin(choices) == -1)
                {
                    PrintMap(choices);
                    System.Console.WriteLine();
                    System.Console.WriteLine("Draw, Thanks For Playing");
                    break;
                }
                else if (CheckWin(choices) == 1)
                {
                    PrintMap(choices);
                    System.Console.WriteLine();
                    System.Console.WriteLine($"Player {((player / 2 - 1) * -1) + 1} Won, Thanks For Playing");
                    break;
                }
            }

        }
        public static void PrintMap(List<string> choices)
        {
            Console.WriteLine($"  {choices.ElementAt(0)}  |  {choices.ElementAt(1)}  |  {choices.ElementAt(2)}  ");
            Console.WriteLine("-----|-----|-----");
            Console.WriteLine($"  {choices.ElementAt(3)}  |  {choices.ElementAt(4)}  |  {choices.ElementAt(5)}  ");
            Console.WriteLine("-----|-----|-----");
            Console.WriteLine($"  {choices.ElementAt(6)}  |  {choices.ElementAt(7)}  |  {choices.ElementAt(8)}  ");
            System.Console.WriteLine();;
        }
        public static int CheckWin(List<string> choices)
        {
            if (choices.ElementAt(0) == choices.ElementAt(1) && choices.ElementAt(1) == choices.ElementAt(2))
                return 1;
            else if (choices.ElementAt(3) == choices.ElementAt(4) && choices.ElementAt(4) == choices.ElementAt(5))
                return 1;
            else if (choices.ElementAt(6) == choices.ElementAt(7) && choices.ElementAt(7) == choices.ElementAt(8))
                return 1;
            else if (choices.ElementAt(0) == choices.ElementAt(3) && choices.ElementAt(3) == choices.ElementAt(6))
                return 1;
            else if (choices.ElementAt(1) == choices.ElementAt(4) && choices.ElementAt(4) == choices.ElementAt(7))
                return 1;
            else if (choices.ElementAt(2) == choices.ElementAt(5) && choices.ElementAt(5) == choices.ElementAt(8))
                return 1;
            else if (choices.ElementAt(0) == choices.ElementAt(4) && choices.ElementAt(4) == choices.ElementAt(8))
                return 1;
            else if (choices.ElementAt(2) == choices.ElementAt(4) && choices.ElementAt(4) == choices.ElementAt(6))
                return 1;
            else if (choices.All(c=>c=="X" || c=="O") == true)
                return -1;
            else
                return 0;
        }
    }
}