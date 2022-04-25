using System.Collections.Generic;

namespace Bowling
{
    class ScoreOpenFrame : IScore
    {
        public int Score(List<Frames> frames, int numberOfTheFrame)
        {
            return frames[numberOfTheFrame].FirstThrow + frames[numberOfTheFrame].SecondThrow;
        }
    }
}