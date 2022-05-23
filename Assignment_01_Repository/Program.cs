using System;

namespace session1
{
    class Program
    {
        static void Main(string[] args)
        {
           // Hello world 
              Console.WriteLine("Hello World !");
           // variables
              int age = 18;
              string name= "AbtinChegini" ;
           // string concatenation
              Console.WriteLine("String Concatenation");
              Console.WriteLine("Hello my name is " + name + ", Iam "+ age + "years old" );   
           // string formating 
               Console.WriteLine("String Formating");
               Console.WriteLine("Hello my name is {0} , Iam {1}years old",name,age ); 
           // string interpolation
               Console.WriteLine("String Interpolation");
               Console.WriteLine($"Hello my name is {name} , Iam {age}years old" ); 
            // verbatim strings
               Console.WriteLine("Verbatim Strings");
               Console.WriteLine(@"Contrary to popular belief, Lorem Ipsum 
                is not simply random text. It has roots in a piece of cla
                ssical Latin literature from 45 BC, making it over 2000 years old. 
                Richard McClintock, a Latin professor at Hampden-Sydney College in Virgini
                a, looked up one of the more obscure Latin words, consectetur, from a Lorem Ipsu
                m passage, and going through the cites of the word in classical literature, discovered the 
                undoubtable source. Lorem Ipsum comes from sections 1.10.32 and 1.10.33 of"); 
                Console.WriteLine(@"/Users/abtin_cheg/Desktop/C#/session1");
                 
        
        }
    }
}
