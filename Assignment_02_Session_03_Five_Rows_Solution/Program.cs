using System;

namespace Test1
{
    class Program
    {
        static void Main(string[] args)
        {
            int column = 1;
            int row = 1;
            int counter = 1;
            while (row <= 5)
            {
                while (column <= 9)
                {
                    switch (column)
                    {
                        case < 5:
                        counter = ((column % 5) + row);
                        break;
                        case > 5:
                        counter = (10 - column + row);
                        break;
                        default:
                        counter = 5 + row;
                        break;
                    }
                    if (counter <= 5)
                    {
                        Console.Write(" ");
                    }
                    else
                    {
                        Console.Write(counter - 5);
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