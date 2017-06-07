
namespace _10.DataOverflow
{
    using System;

    public class Program
    {
        public static void Main()
        {
            ulong firstNum = ulong.Parse(Console.ReadLine());
            ulong secondNum = ulong.Parse(Console.ReadLine());

            ulong minNumber = Math.Min(firstNum, secondNum);
            ulong maxNumber = Math.Max(firstNum, secondNum);

            string maxNumType = string.Empty;
            string minNumType = string.Empty;

            if(maxNumber <= byte.MaxValue)
            {
                maxNumType = "byte";
            }
            else if (maxNumber <= ushort.MaxValue)
            {
                maxNumType = "ushort";
            }
            else if (maxNumber <= uint.MaxValue)
            {
                maxNumType = "uint";
            }
            else if (maxNumber <= ulong.MaxValue)
            {
                maxNumType = "ulong";
            }

            ulong minNumMaxValue = ulong.MaxValue;

            if (minNumber <= byte.MaxValue)
            {
                minNumType = "byte";
                minNumMaxValue = byte.MaxValue;
            }
            else if (minNumber <= ushort.MaxValue)
            {
                minNumType = "ushort";
                minNumMaxValue = ushort.MaxValue;
            }
            else if (minNumber <= uint.MaxValue)
            {
                minNumType = "uint";
                minNumMaxValue = uint.MaxValue;
            }
            else if (minNumber <= ulong.MaxValue)
            {
                minNumType = "ulong";
            }

            double timesOfOverflow = Math.Round(maxNumber /(double)minNumMaxValue);

            Console.WriteLine($"bigger type: {maxNumType}");
            Console.WriteLine($"smaller type: {minNumType}");
           
            Console.WriteLine($"{maxNumber} can overflow {minNumType} {timesOfOverflow} times");

        }
    }
}
