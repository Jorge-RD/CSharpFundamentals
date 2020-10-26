using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CSharpFundamentals.ExampleList
{
    class ExampleList
    {

        public void PrintingList(List<int> list) => list.ForEach((item) => Console.Write($"{item}\t"));

        public void PrintingList(string message, List<int> list)
        {
            Console.WriteLine($"\n\n{message}");
            list.ForEach((item) => { 
                Console.Write($"{item}\t");
            });
        }

        public void PrintingList(string message, IEnumerable<int> list)
        {
            Console.WriteLine($"\n\n{message}");
            foreach (var item in list)
            {
                Console.WriteLine(item);
            }

        }

        public void Example()
        {
            var numbersList = new List<int>() { 1, 2, 3 };
            var numbers = new int[3] { 4, 5, 6 };
            numbersList.AddRange(numbers);
            PrintingList(numbersList);

            numbersList.Reverse();
            PrintingList("Reverse", numbersList);
        }
    }
}

