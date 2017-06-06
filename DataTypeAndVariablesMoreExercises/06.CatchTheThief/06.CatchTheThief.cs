
namespace _06.CatchTheThief
{
    using System;

    public class Program
    {
        public static void Main()
        {
            string numeralType = Console.ReadLine().ToLower();
            int countIDs = int.Parse(Console.ReadLine());

            long maxValue = long.MaxValue;

            switch (numeralType)
            {
                case "sbyte":
                    maxValue = sbyte.MaxValue;
                    break;
                case "int":
                    maxValue = int.MaxValue;
                    break;
                default:
                    break;
            }
            long thiefId = long.MinValue;

            for (int i = 0; i < countIDs; i++)
            {
                long tempID = long.Parse(Console.ReadLine());

                if (tempID > thiefId && tempID <= maxValue)
                {
                    thiefId = tempID;
                }
                
            }
            Console.WriteLine(thiefId);
        }
    }
}
