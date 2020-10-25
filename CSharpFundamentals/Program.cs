using System;
using CSharpFundamentals.Math;

namespace CSharpFundamentals
{
    class Program
    {
        static void Main(string[] args)
        {
            //PrintPrimitiveValues();
            Person person = new Person
            {
                FirstName = "John",
                LastName = "Smith"
            };
            person.Introduce();

            Calculator calculator = new Calculator();
            var result = calculator.Add(1, 2);
            Console.WriteLine($"The result of sum is {result}");
        }

        static void PrintPrimitiveValues()
        {
            const int typeInt = 2;
            const byte typeByte = 2;
            const float typeFloat = 2f;
            const char typeChart = 'F';
            const bool typeBoolean = !false;

            Console.WriteLine($"{typeInt}, {typeInt.GetType()}");
            Console.WriteLine($"{typeByte}, {typeByte.GetType()}");
            Console.WriteLine($"{typeFloat}, {typeFloat.GetType()}");
            Console.WriteLine($"{typeChart}, {typeChart.GetType()}");
            Console.WriteLine($"{typeBoolean}, {typeBoolean.GetType()}");

        }

    }
}
