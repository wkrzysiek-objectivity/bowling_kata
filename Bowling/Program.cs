using System;

namespace Bowling
{
    class Program : BowlingGame
    {
        static void Main(string[] args)
        {
            Throws throws = new Throws();

            Console.WriteLine("Result is: " + BowlingGame.RunBowlingGame(throws.GetThrowsFromUser()));
            Console.ReadLine();
        }
    }
}
