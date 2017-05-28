
namespace _05.BMPCounter
{
    using System;

    public class Program
    {
        public static void Main()
        {
            double beatsPerMinutes = double.Parse(Console.ReadLine());
            double numberOfBeats = double.Parse(Console.ReadLine());

            double bars = Math.Round(numberOfBeats / 4.0, 1);
            double secondsForBeat = 60 / beatsPerMinutes;
            double totalSeconds = secondsForBeat * numberOfBeats;

            int minutes = (int)totalSeconds / 60;
            int seconds = (int)totalSeconds % 60;

            Console.WriteLine($"{bars} bars - {minutes}m {seconds}s");


        }
    }
}
