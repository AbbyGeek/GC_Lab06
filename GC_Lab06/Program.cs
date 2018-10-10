using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GC_Lab06
{
    class Program
    {
        static void Main(string[] args)
        {
            
            /// enter dice sides
            Console.WriteLine("How many sides will your dice have?");
            int sides = Convert.ToInt32(Console.ReadLine());
            /// initiate roll
            Console.WriteLine("Enter 'roll' to start");
            string go = Console.ReadLine();
            /// roll two dice
            Random r = new Random();


            while (go == "y" || go == "roll")
                {
                    int FirstRoll = RollResult(sides, r);
                    int SecondRoll = RollResult(sides, r);
                Console.WriteLine(FirstRoll + "\n" + SecondRoll);
                if (FirstRoll == 1 && SecondRoll == 1)
                {
                    Console.WriteLine("Snake Eyes!");
                }
                if (FirstRoll == 6 && SecondRoll == 6)
                {
                    Console.WriteLine("Boxcars!");
                }
                if (FirstRoll + SecondRoll == 7)
                {
                    Console.WriteLine("Craps!.... (that menans '7', right?)");
                }


                Console.WriteLine("\n Roll again? (y/n)");
                go = Console.ReadLine();
                
                }
                
            
            /// ask to roll again
            
        }
        private static int RollResult(int sides, Random r)
        {
            return r.Next(1, sides+1);
        }
    }
}
