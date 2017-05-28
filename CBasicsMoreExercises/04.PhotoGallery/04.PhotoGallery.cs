
namespace _04.PhotoGallery
{
    using System;

    public class Program
    {
        public static void Main()
        {
            int numberOfPhoto = int.Parse(Console.ReadLine());
            int dayTaken = int.Parse(Console.ReadLine());
            int monthTaken = int.Parse(Console.ReadLine());
            int yearTaken = int.Parse(Console.ReadLine());
            int hoursTaken = int.Parse(Console.ReadLine());
            int minutesTaken = int.Parse(Console.ReadLine());
            int sizeInBytes = int.Parse(Console.ReadLine());
            int widthOfPicture = int.Parse(Console.ReadLine());
            int heightOfPicture = int.Parse(Console.ReadLine());

            string date = $"{dayTaken:D2}/{monthTaken:D2}/{yearTaken:D4} {hoursTaken:D2}:{minutesTaken:D2}";
            
            string size = string.Empty;

            if (sizeInBytes < 1000)
            {
                size = $"{sizeInBytes}B";
            }
            else if (sizeInBytes < 1000000)
            {
                size = $"{Math.Round((sizeInBytes / 1000.0), 1)}KB";
            }
            else
            {
                size = $"{Math.Round((sizeInBytes / 1000000.0), 1)}MB";
            }

            string pictureFormat = string.Empty;

            if (widthOfPicture > heightOfPicture)
            {
                pictureFormat = "landscape";
            }
            else if (widthOfPicture < heightOfPicture)
            {
                pictureFormat = "portrait";
            }
            else
            {
                pictureFormat = "square";
            }

            Console.WriteLine($"Name: DSC_{numberOfPhoto:D4}.jpg");
            Console.WriteLine($"Date Taken: {date}");
            Console.WriteLine($"Size: {size}");
            Console.WriteLine($"Resolution: {widthOfPicture}x{heightOfPicture} ({pictureFormat})");
        }
    }
}
