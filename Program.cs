using System;

namespace BALLS98
{ 
    class Program
    {
        static void Main(string[] args)
        {
            int balls = 0;
            Console.WriteLine("Welcome to Balls98, the latest and greatest technology!");
            Console.WriteLine("Type \"p\" to get a ball!");
            string input = Console.ReadLine();
            while (true)
            {
                if (input == "p")
                {
                    balls++;

                }
                else
                {
                    Console.WriteLine("Invalid Command! You absolute buffoon!");
                }
                string answer = Console.ReadLine();
                
                if (answer == "p")
                {
                    Console.WriteLine($"+ 1 Ball! you now have {balls} balls!");
                    continue;
                }
                else
                {
                    Console.WriteLine("Invalid Command! You absolute buffoon!");
                    balls--;
                    continue;
                }
               }
            }
        }
    }
