using System;

namespace UsernameAndPassword
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Good Morning!");
            string Username = "Shrek";
            string Password = "Yoda69";
            int counter = 0;
            while(counter < 3)
            {
                
                Console.WriteLine("What is your Username and Password?");
                Console.WriteLine("Username: ");
                Username = Console.ReadLine();
                Console.WriteLine("Password: ");
                Password = Console.ReadLine();
                if(Username == "Shrek" && Password == "Yoda69")
                {
                    Console.WriteLine("Welcome");
                    break;
                }
                else
                {
                    Console.WriteLine("Try again!");
                   counter = counter + 1;
                   
                    
                    
                    
                }
            } 
             
            Console.WriteLine("Access denied, stoopid.");
                
            
            
            
                
            
        }
    }
}
