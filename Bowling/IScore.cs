using System.Collections.Generic;

namespace Bowling
{
    internal interface IScore
    {
        int Score(List<Frames> frames, int numberOfTheFrame);
    }
}
