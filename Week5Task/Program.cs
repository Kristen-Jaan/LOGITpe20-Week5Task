using System;

namespace Week5Task
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Good Morning!");
            Random rnd = new Random();
            int RandomDiceRoll;
            int sum = 0;
            int counter = 0;
            while(counter < 5)
            {
                

                RandomDiceRoll = rnd.Next(1, 7);
                Console.WriteLine($"Your dice roll is {RandomDiceRoll}.");
                sum = sum + RandomDiceRoll;
                counter ++;
                
                

            }

            Console.WriteLine($"All add up is {sum}.");

            
            
            

            
            
                
                
                
                
                    
                
               
            


        }
    }
}
