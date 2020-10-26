using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CSharpFundamentals.ExampleArrays
{
    class ExampleArrays
    {
        public void PrintArrayNumbers()
        {
            var numbers = new int[3];
            numbers[0] = 1;
            Console.WriteLine(numbers[0]);
            Console.WriteLine(numbers[1]);
            Console.WriteLine(numbers[2]);
        }
        public void PrintArrayString()
        {
            var names = new string[3] { "John", "Snow", "Targaryen" };
            Console.WriteLine(string.Join(" ", names));
        }
    }
}
