using System;
using System.Collections.Generic;

namespace Test1
{
    class Program
    {
        static void Main(string[] args)
        {
            string Word = RandomWord();
            Console.WriteLine(Word); // For Testing The Program
            int Length = Word.Length;
            int attempts = 6;
            int RemainingLetters = 0;
            List<string> HangingPic = new List<string>();
            List<string> Letter = new List<string>();
            System.Console.WriteLine("Welcome To Hangman Game");
            System.Console.WriteLine("===============================");
            while (attempts >= 0)
            {
                System.Console.Write("Please Guess A Letter: ");
                string? chr = System.Console.ReadLine();
                Letter.Add(chr);
                if (SearchList(Letter, chr) == false)
                {
                    System.Console.WriteLine("Wrong Input OR Repetitive Input");
                }     
                RemainingLetters = SearchLetter(chr, Word);
                if (SearchList(Letter, chr) == true)
                    Length = Length - RemainingLetters;
                if (RemainingLetters != 0)
                {
                    if (SearchList(Letter, chr) == true)
                        System.Console.WriteLine("Right Guess");
                    System.Console.Write($"Letters Guessed So Far: ");
                    foreach(var item in Letter)
                        System.Console.Write($"{item} ");
                    System.Console.WriteLine();
                }
                else if (RemainingLetters == 0)
                {
                    if (SearchList(Letter, chr) == true)
                    {
                    attempts--;
                    switch (attempts)
                    {
                        case 5:
                        HangingPic = Map();
                        HangingPic[11] = "O";
                        System.Console.Write($"Letters Guessed So Far: ");
                        foreach(var item in Letter)
                            System.Console.Write($"{item} ");
                        System.Console.WriteLine();
                        System.Console.WriteLine();
                        PrintMap(HangingPic);
                        System.Console.WriteLine();
                        System.Console.WriteLine();
                        break;
                        case 4:
                        HangingPic[20] = "|";
                        System.Console.Write($"Letters Guessed So Far: ");
                        foreach(var item in Letter)
                            System.Console.Write($"{item} ");
                        System.Console.WriteLine();
                        System.Console.WriteLine();
                        PrintMap(HangingPic);
                        System.Console.WriteLine();
                        System.Console.WriteLine();
                        break;
                        case 3:
                        HangingPic[19] = "/";
                        System.Console.Write($"Letters Guessed So Far: ");
                        foreach(var item in Letter)
                            System.Console.Write($"{item} ");
                        System.Console.WriteLine();
                        System.Console.WriteLine();
                        PrintMap(HangingPic);
                        System.Console.WriteLine();
                        System.Console.WriteLine();
                        break;
                        case 2:
                        HangingPic[21] = "\\";
                        System.Console.Write($"Letters Guessed So Far: ");
                        foreach(var item in Letter)
                            System.Console.Write($"{item} ");
                        System.Console.WriteLine();
                        System.Console.WriteLine();
                        PrintMap(HangingPic);
                        System.Console.WriteLine();
                        System.Console.WriteLine();
                        break;
                        case 1:
                        HangingPic[28] = "/";
                        System.Console.Write($"Letters Guessed So Far: ");
                        foreach(var item in Letter)
                            System.Console.Write($"{item} ");
                        System.Console.WriteLine();
                        System.Console.WriteLine();
                        PrintMap(HangingPic);
                        System.Console.WriteLine();
                        System.Console.WriteLine();
                        break;
                    }
                    }
                }
                if (attempts == 0 && Length > 0)
                {
                    HangingPic[30] = "\\";
                    System.Console.Write($"Total Guessed Letters List: ");
                    foreach(var item in Letter)
                        System.Console.Write($"{item} ");
                    System.Console.WriteLine();
                    System.Console.WriteLine();
                    PrintMap (HangingPic);
                    System.Console.WriteLine();
                    System.Console.WriteLine();
                    System.Console.WriteLine("Game Is Over, Thanks For Playing");
                    break;
                }
                else if ((Length == 0) && (attempts >= 0))
                {
                    System.Console.WriteLine();
                    System.Console.WriteLine();
                    System.Console.WriteLine($"Congratulations, you've Won The Game, The Word is {Word}");
                    break;
                }
            }
        }
        public static string RandomWord()
        {
            List<string> Word = new List<string>();
            Word.Add("zero");
            Word.Add("kevin");
            Word.Add("pouya");
            Word.Add("black");
            Word.Add("earth");
            Word.Add("layer");
            Word.Add("intel");
            Word.Add("eight");
            Word.Add("mean");
            Word.Add("melo");
            Word.Add("mars");
            Word.Add("end");
            Word.Add("zone");
            Word.Add("park");
            Word.Add("class");
            Word.Add("people");
            Word.Add("wrong");
            Word.Add("ross");
            Word.Add("dear");
            Word.Add("morty");
            Word.Add("payam");
            Word.Add("drone");
            Word.Add("harp");
            Word.Add("wawe");
            Random random = new Random();
            int index = random.Next(0, 23);
            string word = Word[index];
            return word;
        }
        public static List<string> Map()
        {
            List<string> map = new List<string>();
            int index = 0;
            while (index < 45)
            {
                if ((index == 2) || (index == 6))
                    map.Insert(index, "+");
                else if ((index > 2) && (index < 6))
                    map.Insert(index, "-");
                else if ((index == 15) || (index == 24) || (index == 33))
                    map.Insert(index, "|");
                else if ((index > 40) && (index < 44))
                    map.Insert(index, "=");
                else if ((index == 8) || (index == 17) || (index == 26) || (index == 35))
                    map.Insert(index, "\n");
                else
                    map.Insert(index, " ");
                index++;
            }
            return map;        
        }
        public static void PrintMap(List<string> a)
        {
            foreach(var item in a)
            {
                System.Console.Write(item);
            }
        }
        public static int SearchLetter(string letter, string word)
        {
            int ctr;
            int j = 0;
            for (ctr = 0; ctr <= (word.Length - 1); ctr++)
            {
                if (word.Substring(ctr, 1) == letter)
                    j++;
            }
            return j;
        }
        public static bool SearchList(List<string> letter, string chr)
        {
            int ctr = 0;
            letter.Add("");
            if (chr.Length > 1 || chr == null || chr.Length == 0)
                return false;
            else
            {
                foreach (var item in letter)
                {
                    if (item == chr)
                        ctr++;
                }
            }
            if (ctr == 1)
                return true;
            else
                return false;
        }
    }
}