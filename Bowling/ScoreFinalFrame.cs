using System.Collections.Generic;

namespace Bowling
{
    class ScoreFinalFrame : IScore
    {
        public int Score(List<Frames> frames, int numberOfTheFrame)
        {
            int score;

            if (frames[numberOfTheFrame].FirstThrow == 10)
            {
                score = frames[numberOfTheFrame].FirstThrow + frames[numberOfTheFrame].SecondThrow + frames[numberOfTheFrame].ThirdThrow;
            }
            else if (frames[numberOfTheFrame].FirstThrow + frames[numberOfTheFrame].SecondThrow == 10)
            {
                score = frames[numberOfTheFrame].FirstThrow + frames[numberOfTheFrame].SecondThrow + frames[numberOfTheFrame].ThirdThrow;
            }
            else
            {
                score = frames[numberOfTheFrame].FirstThrow + frames[numberOfTheFrame].SecondThrow;
            }
            return score;
        }
    }
}