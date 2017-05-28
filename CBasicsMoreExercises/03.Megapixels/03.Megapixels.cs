
namespace _03.Megapixels
{
    using System;

    public class Program
    {
        public static void Main()
        {
            int widthOfPicture = int.Parse(Console.ReadLine());
            int heightOfPicture = int.Parse(Console.ReadLine());

            double resolution = Math.Round(((widthOfPicture * heightOfPicture) / 1000000.0),1);

            Console.WriteLine($"{widthOfPicture}x{heightOfPicture} => {resolution}MP");

        }
    }
}
