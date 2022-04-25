namespace Bowling
{
    public class Frames
    {
        public enum FrameTypeEnum
        {
            OpenFrame,
            Strike,
            Spare
        }
        public FrameTypeEnum FrameType { get; set; }
        public int FirstThrow { get; set; }
        public int SecondThrow { get; set; }
        public int ThirdThrow { get; set; }
    }
}
