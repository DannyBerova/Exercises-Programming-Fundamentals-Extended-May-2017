
namespace __04.Phone
{
    using System;
    using System.Linq;

    public class Program
    {
        public static void Main()
        {
            string[] phoneNumbers = Console.ReadLine().Split();
            string[] names = Console.ReadLine().Split();
            string[] inputName = Console.ReadLine().Split();

            while (inputName[0] != "done")
            {

                if (inputName[0] == "call")
                {
                    for (int i = 0; i < names.Length; i++)
                    {
                        if (inputName[1] == names[i])
                        {
                            Console.WriteLine($"calling {phoneNumbers[i]}...");

                            string phoneNumber = phoneNumbers[i];
                            int sumOfDiggits = TakeSumOfDiggits(phoneNumber);

                            if (sumOfDiggits % 2 == 1)
                            {
                                Console.WriteLine("no answer");
                            }
                            else
                            {
                                int minutes = sumOfDiggits / 60;
                                int seconds = sumOfDiggits % 60;
                                string duration = $"{minutes:d2}:{seconds:d2}";
                                Console.WriteLine($"call ended. duration: {duration}");
                            }
                        }
                        if (inputName[1] == phoneNumbers[i])
                        {
                            Console.WriteLine($"calling {names[i]}...");

                            string phoneNumber = phoneNumbers[i];
                            int sumOfDiggits = TakeSumOfDiggits(phoneNumber);

                            if (sumOfDiggits % 2 == 1)
                            {
                                Console.WriteLine("no answer");
                            }
                            else
                            {
                                int minutes = sumOfDiggits / 60;
                                int seconds = sumOfDiggits % 60;
                                string duration = $"{minutes:d2}:{seconds:d2}";
                                Console.WriteLine($"call ended. duration: {duration}");
                            }
                        }
                    }
                }
                if (inputName[0] == "message")
                {
                    for (int i = 0; i < names.Length; i++)
                    {
                        if (inputName[1] == names[i])
                        {
                            Console.WriteLine($"sending sms to {phoneNumbers[i]}...");
                            
                            string phoneNumber = phoneNumbers[i];
                            int sumOfDiggits = TakeSumOfDiggits(phoneNumber);

                            if (sumOfDiggits % 2 == 0)
                            {
                                Console.WriteLine("meet me there");
                            }
                            else
                            {
                                Console.WriteLine("busy");
                            }
                        }
                        if (inputName[1] == phoneNumbers[i])
                        {
                            Console.WriteLine($"sending sms to {names[i]}...");

                            string phoneNumber = phoneNumbers[i];
                            int sumOfDiggits = TakeSumOfDiggits(phoneNumber);
                            if (sumOfDiggits % 2 == 0)
                            {
                                Console.WriteLine("meet me there");
                            }
                            else
                            {
                                Console.WriteLine("busy");
                            }
                        }
                    }
                }

                inputName = Console.ReadLine().Split();
            }
        }

        private static int TakeSumOfDiggits(string phoneNumber)
        {
            int sumOfDiggits = 0;

            for (int i = 0; i < phoneNumber.Length; i++)
            {
                if (phoneNumber[i] >= 48 && phoneNumber[i] <= 57)
                {
                    sumOfDiggits += ((int)phoneNumber[i] - 48);
                }
            }
            return sumOfDiggits;
        }
    }
}

