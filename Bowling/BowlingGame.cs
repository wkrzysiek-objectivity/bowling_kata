using System.Collections.Generic;

namespace Bowling
{
    public class BowlingGame
    {
        protected static int RunBowlingGame(List<Frames> frames)
        {
            ScoreFinalFrame scoreFinalFrame = new ScoreFinalFrame();

            int score = 0;

            for (int i = 0; i < 9; i++)
            {
                if (frames[i].FrameType == Frames.FrameTypeEnum.Strike)
                {
                    ScoreStrikeFrame scoreStrike = new ScoreStrikeFrame();
                    score += scoreStrike.Score(frames, i);
                }
                else if (frames[i].FrameType == Frames.FrameTypeEnum.Spare)
                {
                    ScoreSpareFrame scoreSpare = new ScoreSpareFrame();
                    score += scoreSpare.Score(frames, i);
                }
                else
                {
                    ScoreOpenFrame scoreOpenFrame = new ScoreOpenFrame();
                    score += scoreOpenFrame.Score(frames, i);
                }
            }

            return score + scoreFinalFrame.Score(frames, 9); 
        }
    }
}
