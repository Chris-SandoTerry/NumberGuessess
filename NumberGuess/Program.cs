using System;

namespace NumberGuess
{

    class Program
    {
        static void Main(string[] args)
        {
            Random r = new Random();

            int winNum = r.Next(0,100);

            bool win = false;

            do
            {
                Console.Write("Guess a number inbetween 0-100.");
                string s = Console.ReadLine();
                int i = int.Parse(s);

                if(i > winNum)
                {
                    Console.WriteLine("Guess lower");
                }
                else if(i < winNum)
                {
                    Console.WriteLine("Guess Higher");
                }
                else if(i == winNum)
                {
                    Console.WriteLine("YOU WIN !!");
                    win = true;
                }
            }while(win == false);
            

            
            
        }

    }

}