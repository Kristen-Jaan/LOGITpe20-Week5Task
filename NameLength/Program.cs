using System;

namespace NameLength
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Good Morning!");
            Console.WriteLine("Enter your first name: ");
            string FirstName = Console.ReadLine();
            Console.WriteLine("Enter your last name: ");
            string LastName = Console.ReadLine();
            int LentghOne = 0;
            int LentghTwo = 0;
            foreach(char letter in FirstName)
            {
                LentghOne = LentghOne + 1;
            }
            foreach(char letter in LastName)
            {
                LentghTwo = LentghTwo + 1;
            }
            if(LentghOne > LentghTwo)
            {
                Console.WriteLine("Your first name is longer than your last name.");
            }
            else if(LentghOne < LentghTwo)
            {
                Console.WriteLine("Your last name is longer than your first name.");
            }
            else
            {
                Console.WriteLine("Both names are the same lentgh.");
            }

        }
    }
}
