using System.Collections.Generic;

namespace Bowling
{
   class ScoreSpareFrame : IScore
    {
        public int Score(List<Frames> frames, int numberOfTheFrame)
        {
            return 10 + frames[numberOfTheFrame + 1].FirstThrow;
        }
    }
}
