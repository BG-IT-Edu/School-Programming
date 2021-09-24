using System;

namespace P01.Stream_Progress
{
    public class Program
    {
        static void Main()
        {
            IStream file = new File("file", 12, 50);
            StreamProgressInfo streamProgressInfo = new StreamProgressInfo(file);
            Console.WriteLine(streamProgressInfo.CalculateCurrentPercent());

            IStream music = new Music("Ivan", "Silence", 12, 530);
            streamProgressInfo = new StreamProgressInfo(music);
            Console.WriteLine(streamProgressInfo.CalculateCurrentPercent());

            IStream video = new Movie("the walking dead", 132, 50);
            streamProgressInfo = new StreamProgressInfo(video);
            Console.WriteLine(streamProgressInfo.CalculateCurrentPercent());
        }
    }
}
