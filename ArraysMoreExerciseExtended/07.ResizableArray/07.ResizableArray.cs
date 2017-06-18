
namespace _07.ResizableArray
{
    using System;
    using System.Linq;

    public class Program
    {
        static int[] elements;
        static int elementsLenght;

        public static void Main()
        {
            string[] inputTokens = Console.ReadLine().Split(' ');

            elements = new int[4];
            elementsLenght = 0;

            while (inputTokens[0] != "end")
            {
                string command = inputTokens[0];

                if (command == "push")
                {
                    elements[elementsLenght] = int.Parse(inputTokens[1]);
                    elementsLenght++;

                    if (elementsLenght >= elements.Length)
                    {
                        ExpandArray();
                    }
                }
                else if (command == "pop")
                {
                    elements[elementsLenght] = 0;
                    elementsLenght--;
                }
                else if (command == "removeAt")
                {
                    int index = int.Parse(inputTokens[1]);
                    ShiftArray(index);
                    elementsLenght--;
                }
                else if (command == "clear")
                {
                    elementsLenght = 0;
                }

                inputTokens = Console.ReadLine().Split(' ');

            }

            if (elementsLenght == 0)
            {
                Console.WriteLine("empty array");
            }
            else
            {
                for (int i = 0; i < elementsLenght; i++)
                {
                    Console.Write(elements[i] + " ");
                }

                Console.WriteLine();
            }

        }

        private static void ShiftArray(int index)
        {
            for (int i = index + 1; i < elementsLenght; i++)
            {
                elements[i - 1] = elements[i];
            }
        }

        private static void ExpandArray()
        {
            Array.Resize(ref elements, elements.Length * 2);
        }
    }
}
