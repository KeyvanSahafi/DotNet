using System;
using System.Linq;

// unknown, milad And pooya Are Banned Users (First Names) (Case Insensetive)//

namespace Test
{
    public class Program
    {
        static void Main(string[] args)
        {
            Username name = new Username();
            name.BannedUsers += Username.Banned;
            name.GetName();
        }     
    }
 
    public class Username
    {
        public event EventHandler BannedUsers;
        public void GetName()
        {
            Console.Write("Enter You Name: ");
            string username = Console.ReadLine();
            if (username.Contains(" ") == false)
            {
                System.Console.WriteLine("Wrong Name. Please Enter Your Full Name");
                return;
            }
            string FirstName = username.Split(' ').ElementAt(0).ToString();
            string Lastname = username.Split(' ').ElementAt(1).ToString();
            if ((FirstName.ToLower() == "unknown" || FirstName.ToLower() == "milad" || FirstName.ToLower() == "pooya"))
                BannedUsers?.Invoke(this, EventArgs.Empty);
            else
                Console.WriteLine("Welcome " + FirstName);
        }
        public static void Banned(object sender, EventArgs e)
        {
            Console.WriteLine("Warning: Banned User. Sending Email to Administration!!!");
        }
    }
}