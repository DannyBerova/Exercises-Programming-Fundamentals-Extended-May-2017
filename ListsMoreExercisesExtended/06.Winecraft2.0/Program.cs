
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
                .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList();
            int seasonDays = int.Parse(Console.ReadLine());
            int countAliveGrapes = grapes.Count;

            while (countAliveGrapes > seasonDays)
            {
                for (int i = 0; i < seasonDays; i++)
                {
                    for (int each = 0; each < grapes.Count; each++)
                    {
                        if (grapes[each] != 0)
                        {
                            grapes[each]++;
                        }
                    }

                    for (int special = 0; special < grapes.Count; special++)
                    {
                        if (!(special == 0) && !(special == grapes.Count - 1))
                        {
                            if (grapes[special - 1] < grapes[special] && grapes[special] > grapes[special + 1])
                            {

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
                        grapes[index] = 0;
                    }
                }

                countAliveGrapes = grapes.Count;
                foreach (var grape in grapes)
                {
                    if (grape == 0)
                    {
                        countAliveGrapes--;
                    }
                }

            }

            Console.WriteLine(string.Join(" ", grapes));
        }
    }
}
