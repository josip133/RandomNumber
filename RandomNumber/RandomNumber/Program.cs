using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumberGuessingGame
{
    class Program
    {
        static void Main(string[] args)
        {
            Random r = new Random();
            
            int winNum = r.Next(0, 100);

            bool win = false;

            do
            {
                Console.WriteLine(" Guess a number between 0 and 100: ");
                string s = Console.ReadLine();  

                int i = int.Parse(s);   

                if (i > winNum)
                {
                    Console.WriteLine("Too high! Guees lower ...");
                }
                else if (i < winNum)
                {
                    Console.WriteLine("Too low! Guess higher ...");
                }
                else if (i == winNum)
                {
                    Console.WriteLine("You win!!!");
                    win = true; 
                }
            } while (win == false);
        }
    }
}