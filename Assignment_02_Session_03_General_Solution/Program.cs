using System;

namespace Test1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Please Enter The Desired Number of Rows: ");
            int numberofrows = Convert.ToInt32(Console.ReadLine());
            int numberofcolumns = ((numberofrows*2) - 1);
            int column = 1;
            int row = 1;
            int counter = 1;
            while (row <= numberofrows)
            {
                while (column <= numberofcolumns)
                {
                    if (column < numberofrows)
                    {
                        counter = ((column % numberofrows) + row);
                    }
                    if (column == numberofrows)
                    {
                        counter = numberofrows + row;
                    }
                    if (column > numberofrows)
                    {
                        counter = ((2*numberofrows) - column + row);
                    }
                    if (counter <= numberofrows)
                    {
                        Console.Write(" ");
                    }
                    else if (counter > numberofrows)
                    {
                        Console.Write(counter - numberofrows);
                    }
                    column++;
                }
                column = 1;
                Console.WriteLine();
                row++;
            }
        }
    }
}