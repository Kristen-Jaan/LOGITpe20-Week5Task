using System;

namespace BugFix
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Good Morning!");
            for(int i = 10; i > 0; i--)
            {
                Console.WriteLine($"There are {i} bugs in the code. Fix one.");
                
            }
            Console.WriteLine("There are no bugs in the wall. That's weird.");
        }
    }
}
