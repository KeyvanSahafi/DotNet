using System;

namespace Test1
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Console.Write("How Many Employee Do you have (Enter an Int): ");
            int numberofemployees = Convert.ToInt32(System.Console.ReadLine());
            List<Income> Lstclass = new List<Income>();
            string? a = "";
            int b = 0;
            int c = 0;
            for (int i = 1; i <= numberofemployees; i++)
            {
                System.Console.Write($"Enter employee #{i}'s Name: ");
                a = System.Console.ReadLine();
                System.Console.Write($"Enter employee #{i}'s Income: ");
                b = Convert.ToInt32(System.Console.ReadLine());
                System.Console.Write($"Enter employee #{i}'s Working Hours: ");
                c = Convert.ToInt32(System.Console.ReadLine());
                Income List = new Income(a, b, c);
                Lstclass.Add(List);
                System.Console.WriteLine();
            }
            foreach (var item in Lstclass)
            {
            System.Console.WriteLine($"Name: {item.Name}");
            System.Console.WriteLine($"Wage per Hour: {item.IncomeCal}");
            System.Console.WriteLine($"Working Hours in a Day: {item.Time}");
            System.Console.WriteLine($"Total Income: {item.IncomeCal * item.Time * 24}");
            System.Console.WriteLine();
            }
        }
    }
}

public class Income
{
    public Income(string name, int income, int workinghours)
    {
        this._name = name;
        this._income = income;
        this._time = workinghours;
    }
    private string _name;
    public string Name
    {
        get { return _name; }
        set { _name = value; }
    }
    
    private int _income;
    public int IncomeCal
    {
        get { return _income; }
        set {_income = value; }
    }
    private int _time;
    public int Time
    {
        get { return _time; }
        set { _time = value; }
    }
}
