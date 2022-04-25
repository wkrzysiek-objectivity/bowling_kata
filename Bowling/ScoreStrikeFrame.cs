using System.Collections.Generic;

namespace Bowling
{
    class ScoreStrikeFrame : IScore
    {
        public int Score(List<Frames> frames, int numberOfTheFrame)
        {
            int score;

            if (numberOfTheFrame == 8)
            {
                score = frames[numberOfTheFrame].FirstThrow + frames[numberOfTheFrame + 1].FirstThrow + frames[numberOfTheFrame + 1].SecondThrow;
            }
            else
            {
                if (frames[numberOfTheFrame + 1].FirstThrow == 10 && frames[numberOfTheFrame + 2].FirstThrow == 10)
                {
                    score = frames[numberOfTheFrame].FirstThrow + frames[numberOfTheFrame + 1].FirstThrow + frames[numberOfTheFrame + 2].FirstThrow;
                }
                else if (frames[numberOfTheFrame + 1].FirstThrow == 10)
                {
                    score = frames[numberOfTheFrame].FirstThrow + frames[numberOfTheFrame + 1].FirstThrow + frames[numberOfTheFrame + 2].FirstThrow;
                }
                else
                {
                    score = frames[numberOfTheFrame].FirstThrow + frames[numberOfTheFrame + 1].FirstThrow + frames[numberOfTheFrame + 1].SecondThrow;
                }
            }

            return score;
        }
    }
}
