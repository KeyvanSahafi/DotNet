using System;
using System.Collections.Generic;

namespace Test1
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Console.Write("How Many Employee Do you have (Enter an Int): ");
            int numberofemployees = Convert.ToInt32(System.Console.ReadLine());
            List<Income> Lstclass = new List<Income>();
            for (int i = 1; i <= numberofemployees; i++)
            {
                System.Console.Write($"Enter employee #{i}'s Name: ");
                string name = System.Console.ReadLine();
                System.Console.Write($"Enter employee #{i}'s Income: ");
                int income = Convert.ToInt32(System.Console.ReadLine());
                System.Console.Write($"Enter employee #{i}'s Working Hours: ");
                int workinghours = Convert.ToInt32(System.Console.ReadLine());
                Income List = new Income(name, income, workinghours);
                Lstclass.Add(List);
                System.Console.WriteLine();
            }
            foreach (var item in Lstclass)
            {
            System.Console.WriteLine($"Name: {item.Name}");
            System.Console.WriteLine($"Wage per Hour: {item.IncomeCal}");
            System.Console.WriteLine($"Working Hours in a Day: {item.Time}");
            System.Console.WriteLine($"Total Income: {item.Salary()}");
            System.Console.WriteLine();
            }
        }
    }
}

public class Income
{
    public Income(string name, int income, int workinghours)
    {
        this.Name = name;
        this.IncomeCal = income;
        this.Time = workinghours;
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
        set { _income = value; }
    }
    private int _time;
    public int Time
    {
        get { return _time; }
        set { _time = value; }
    }
    public int Salary()
    {
        int salary = Time * IncomeCal * 24;
        return salary;
    }
}
