
namespace _06.Winecraft
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Program
    {
        public static void Main()
        {
            List<int> grapes = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToList();
            int seasonDays = int.Parse(Console.ReadLine());

            while (grapes.Count > seasonDays)
            {
                for (int i = 0; i < seasonDays; i++)
                {
                    for (int each = 0; each < grapes.Count; each++)
                    {
                            grapes[each]++;
                    }

                    for (int special = 0; special < grapes.Count; special++)
                    {
                        if (!(special == 0) && !(special == grapes.Count - 1))
                        {
                            if (grapes[special - 1] < grapes[special] && grapes[special] > grapes[special + 1])
                            {
                                grapes[special]--;

                                if (grapes[special - 1] > 0)
                                {
                                    grapes[special - 1] = Math.Max(grapes[special - 1] - 2, 0);
                                    grapes[special]++;
                                }
                                if (grapes[special + 1] > 0)
                                {
                                    grapes[special + 1] = Math.Max(grapes[special + 1] - 2, 0);
                                    grapes[special]++;
                                }
                            }
                        }
                    }
                }

                for (int index = 0; index < grapes.Count; index++)
                {
                    if (grapes[index] <= seasonDays)
                    {
                        grapes.RemoveAt(index);
                        index--;
                    }
                }
            }

            Console.WriteLine(string.Join(" ", grapes));
        }
    }
}
