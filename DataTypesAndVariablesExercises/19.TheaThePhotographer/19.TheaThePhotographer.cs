
namespace _19.TheaThePhotographer
{
    using System;

    public class Program
    {
        public static void Main()
        {
            int picturesCount = int.Parse(Console.ReadLine());
            int filterTimePerPicture = int.Parse(Console.ReadLine());
            int filterPercentage = int.Parse(Console.ReadLine());
            int uploadTimePerPicture = int.Parse(Console.ReadLine());

            var filterTimeInSeconds = (long)picturesCount * filterTimePerPicture;
            var usablePictures = (long)Math.Ceiling(picturesCount * (filterPercentage / 100d));
            var uploadTimeInSeconds = usablePictures * uploadTimePerPicture;
            var totalTimeInSeconds = filterTimeInSeconds + uploadTimeInSeconds;

            var totalTimeNeededTimeSpan = TimeSpan.FromSeconds(totalTimeInSeconds);

            Console.WriteLine(totalTimeNeededTimeSpan.ToString(@"d\:hh\:mm\:ss"));



        }
    }
}
