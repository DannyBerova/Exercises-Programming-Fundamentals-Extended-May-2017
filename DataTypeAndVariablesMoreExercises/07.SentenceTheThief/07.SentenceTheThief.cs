
namespace _07.SentenceTheThief
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

            sbyte num = 0;
            if (thiefId < 0)
            {
                num = sbyte.MinValue;
            }
            else
            {
                num = sbyte.MaxValue;
            }
            
            double years = Math.Ceiling((double)thiefId / num);

            Console.WriteLine("Prisoner with id {0} is sentenced to {1} {2}",
                thiefId,
                years,
                years > 1 ? "years": "year");
        }
    }
}
