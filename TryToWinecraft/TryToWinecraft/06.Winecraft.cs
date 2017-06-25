namespace _TryToWinecraft
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class Winecraft
    {
        static List<int> grapes;
        static void Main()
        {
            grapes = Console.ReadLine()
                .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList();
            int growthDays = int.Parse(Console.ReadLine());

            do
            {
                for (int each = 0; each < growthDays; each++)
                {
                    ProcessGrapes();
                }

                HibernateRetardedGrapes(growthDays);

            } while (MightyGrapesAreMoreThan(growthDays));

            RemoveDeadGrapes(grapes);

            Console.WriteLine(string.Join(" ", grapes));
        }

        static void ProcessGrapes()
        {
            for (int index = 0; index < grapes.Count; index++)
            {
                if (!IsAlive(index))
                {
                    continue;
                }

                if (IsGreaterGrape(index))
                {
                    grapes[index]++;

                    if (IsAlive(index - 1))
                    {
                        grapes[index]++;
                        grapes[index - 1]--;
                    }

                    if (IsAlive(index + 1))
                    {
                        grapes[index]++;
                        grapes[index + 1]--;
                    }
                }
                else if (IsLesserGrape(index))
                {
                }
                else
                {
                    grapes[index]++;
                }
            }
        }

        static bool MightyGrapesAreMoreThan(int growthDays)
        {
            return grapes
                .Where(g => g > growthDays)
                .Count() >= growthDays;
        }

        static void HibernateRetardedGrapes(int growthDays)
        {
            for (int cnt = 0; cnt < grapes.Count; cnt++)
            {
                if (grapes[cnt] <= growthDays)
                {
                    grapes[cnt] = 0;
                }
            }
        }

        private static void RemoveDeadGrapes(List<int> grapes)
        {
            for (int index = 0; index < grapes.Count; index++)
            {
                if (grapes[index] == 0)
                {
                    grapes.RemoveAt(index);
                    index--;
                }
            }
        }

        static bool IsAlive(int index)
        {
            if (index < 0 || index >= grapes.Count)
            {
                return false;
            }

            return grapes[index] > 0;
        }

        static bool IsGreaterGrape(int index)
        {
            if (index <= 0 || index >= (grapes.Count - 1))
            {
                return false;
            }

            return (grapes[index] > grapes[index - 1] &&
                    grapes[index] > grapes[index + 1]);
        }

        static bool IsLesserGrape(int index)
        {
            return (IsGreaterGrape(index - 1) ||
                    IsGreaterGrape(index + 1));
        }
    }
}
