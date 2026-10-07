using System;

class Program
{
    
        static double AddNumbers(double x, int y)
        {
            return x + y;
        }

        static void DisplayGreeting(string name)
        {
        Console.WriteLine($"Welcome {name}, pleased to meet you.");
        }
        static void Main(string[] args)
        {
            DisplayGreeting("Bob");
            Console.WriteLine(AddNumbers(12.234, 10));

        // bool done = false;
        
        // while (! done)
        // {
        //     Console.Write("Are we done (y/n): ");
        //     done = Console.ReadLine() == "y";
        // }

        // bool done;

        // do
        // {
        //     Console.Write("Are we done (y/n): ");
        //     done = Console.ReadLine() == "y";
        // } while(!done);

        // for(int i = 100000; i > -100001; i-=10000)
        // {
        //     Console.WriteLine(i);
        // }

        // List<string> myFriends = new List<string> {"Bob", "Betty", "Bubba"};
        // myFriends.Add("James");
        // myFriends.Add("Doug");

        // foreach(string name in myFriends)
        // {
        //     Console.WriteLine(name);
        // }

        }
    
}