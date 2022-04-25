using Microsoft.VisualStudio.TestTools.UnitTesting;
using Bowling;
using System.Collections.Generic;

namespace BowlingTests
{
    [TestClass]
    public class BowlingUnitTests : BowlingGame
    {
        [TestMethod]
        public void StrikeInAllFrames()
        {
            List<Frames> frames = new List<Frames>();

            // For first 9 frames add strike in first throw
            for (int i = 0; i < 9; i++)
            {
                frames.Add(new Frames() { FirstThrow = 10, FrameType = Frames.FrameTypeEnum.Strike });
            }

            // For 10th frame add strike in first, second and third throw
            frames.Add(new Frames() { FirstThrow = 10, SecondThrow = 10, ThirdThrow = 10, FrameType = Frames.FrameTypeEnum.Strike });

            Assert.AreEqual(300, BowlingGame.RunBowlingGame(frames));
        }

        [TestMethod]
        public void TenFramesOfNineAndMiss()
        {
            List<Frames> frames = new List<Frames>();

            // For each frame add 9 in first and 0 in second throw
            for (int i = 0; i < 10; i++)
            {
                frames.Add(new Frames() { FirstThrow = 9, SecondThrow = 0, FrameType = Frames.FrameTypeEnum.OpenFrame });
            }

            Assert.AreEqual(90, BowlingGame.RunBowlingGame(frames));
        }

        [TestMethod]
        public void SpareInEachFrame()
        {
            List<Frames> frames = new List<Frames>();

            // For first 9 frames add spare
            for (int i = 0; i < 9; i++)
            {
                frames.Add(new Frames() { FirstThrow = 5, SecondThrow = 5, FrameType = Frames.FrameTypeEnum.Spare });
            }

            // For 10th frame add spare in second throw and 5 in third throw
            frames.Add(new Frames() { FirstThrow = 5, SecondThrow = 5, ThirdThrow = 5, FrameType = Frames.FrameTypeEnum.Spare });

            Assert.AreEqual(150, BowlingGame.RunBowlingGame(frames));
        }
    }
}
