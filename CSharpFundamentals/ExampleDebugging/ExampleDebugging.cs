using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpFundamentals.ExampleDebugging
{
    public class ExampleDebugging
    {
        public void PrintingNumbers()
        {
            List<int> numbers = new List<int> { 1, 2, 3, 4, 5, 6 };
            List<int> smallest = GetSmallest(numbers, 3);
            smallest.ForEach((number) => {
                Console.WriteLine(number);
            });
        }
        public static List<int> GetSmallest(List<int> list, int count)
        {
            List<int> smallests = new List<int>();
            while (smallests.Count < count)
            {
                int min = GetSmallest(list);
                smallests.Add(min);
                list.Remove(min);
            }
            return smallests;
        }

        public static int GetSmallest(List<int> list)
        {
            int min = list[0];
            list.ForEach((number) => {
                if (number < min)
                {
                    min = number;
                }
            });
            return min;
        }
    }
}
