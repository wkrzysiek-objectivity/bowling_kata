using System;
using System.Collections.Generic;

namespace Bowling
{
    public class Throws
    {
        public List<Frames> GetThrowsFromUser()
        {
            List<Frames> frames = new List<Frames>();
            int firstThrow;
            int secondThrow;
            int thirdThrow;

            Console.WriteLine("Enter the result of throws.");

            Console.WriteLine();
            Console.WriteLine("FIRST FRAME");
            Console.WriteLine("------------------");
            Console.WriteLine("1st throw:");
            firstThrow = TryParseValueFromUser(Console.ReadLine());
            IsStrikeInFirstThrow(firstThrow, frames);

            Console.WriteLine();
            Console.WriteLine("SECOND FRAME");
            Console.WriteLine("------------------");
            Console.WriteLine("1st throw:");
            firstThrow = TryParseValueFromUser(Console.ReadLine());
            IsStrikeInFirstThrow(firstThrow, frames);

            Console.WriteLine();
            Console.WriteLine("THIRD FRAME");
            Console.WriteLine("------------------");
            Console.WriteLine("1st throw:");
            firstThrow = TryParseValueFromUser(Console.ReadLine());
            IsStrikeInFirstThrow(firstThrow, frames);

            Console.WriteLine();
            Console.WriteLine("FOURTH FRAME");
            Console.WriteLine("------------------");
            Console.WriteLine("1st throw:");
            firstThrow = TryParseValueFromUser(Console.ReadLine());
            IsStrikeInFirstThrow(firstThrow, frames);

            Console.WriteLine();
            Console.WriteLine("FIFTH FRAME");
            Console.WriteLine("------------------");
            Console.WriteLine("1st throw:");
            firstThrow = TryParseValueFromUser(Console.ReadLine());
            IsStrikeInFirstThrow(firstThrow, frames);

            Console.WriteLine();
            Console.WriteLine("SIXTH FRAME");
            Console.WriteLine("------------------");
            Console.WriteLine("1st throw:");
            firstThrow = TryParseValueFromUser(Console.ReadLine());
            IsStrikeInFirstThrow(firstThrow, frames);

            Console.WriteLine();
            Console.WriteLine("SEVEN FRAME");
            Console.WriteLine("------------------");
            Console.WriteLine("1st throw:");
            firstThrow = TryParseValueFromUser(Console.ReadLine());
            IsStrikeInFirstThrow(firstThrow, frames);

            Console.WriteLine();
            Console.WriteLine("EIGHTH FRAME");
            Console.WriteLine("------------------");
            Console.WriteLine("1st throw:");
            firstThrow = TryParseValueFromUser(Console.ReadLine());
            IsStrikeInFirstThrow(firstThrow, frames);

            Console.WriteLine();
            Console.WriteLine("NINTH FRAME");
            Console.WriteLine("------------------");
            Console.WriteLine("1st throw:");
            firstThrow = TryParseValueFromUser(Console.ReadLine());
            IsStrikeInFirstThrow(firstThrow, frames);

            Console.WriteLine();
            Console.WriteLine("TENTH FRAME");
            Console.WriteLine("------------------");
            Console.WriteLine("1st throw:");
            firstThrow = TryParseValueFromUser(Console.ReadLine());
            Console.WriteLine("2nd throw:");
            secondThrow = TryParseValueFromUser(Console.ReadLine());

            if (firstThrow == 10 || firstThrow + secondThrow == 10)
            {
                Console.WriteLine("3rd throw:");
                thirdThrow = TryParseValueFromUser(Console.ReadLine());
                frames.Add(new Frames() { FirstThrow = firstThrow, SecondThrow = secondThrow, ThirdThrow = thirdThrow });
            }
            else
            {
                frames.Add(new Frames() { FirstThrow = firstThrow, SecondThrow = secondThrow });
            }

            return frames;
        }
        public int TryParseValueFromUser(string value)
        {
            int throwInt;

            while (!Int32.TryParse(value, out throwInt))
            {
                Console.WriteLine("Not a valid number, try again.");
                value = Console.ReadLine();
            }

            return throwInt;
        }
        public List<Frames> IsStrikeInFirstThrow(int firstThrow, List<Frames> frames)
        {
            if (firstThrow == 10)
            {
                frames.Add(new Frames() { FirstThrow = firstThrow, FrameType = SetFrameType() });
            }
            else
            {
                Console.WriteLine("2nd throw:");
                int secondThrow = Int32.Parse(Console.ReadLine());
                frames.Add(new Frames() { FirstThrow = firstThrow, SecondThrow = secondThrow, FrameType = SetFrameType(firstThrow, secondThrow) });
            }
            return frames;
        }
        public Frames.FrameTypeEnum SetFrameType()
        {
            return Frames.FrameTypeEnum.Strike;
        }
        public Frames.FrameTypeEnum SetFrameType(int firstThrow, int secondFrame)
        {
            return (firstThrow + secondFrame == 10 ? Frames.FrameTypeEnum.Spare : Frames.FrameTypeEnum.OpenFrame);
        }
    }
}