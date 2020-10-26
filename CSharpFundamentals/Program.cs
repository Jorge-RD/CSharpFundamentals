using System;
using CSharpFundamentals.ExampleString;
using CSharpFundamentals.Math;

namespace CSharpFundamentals
{
    class Program
    {
        static void Main(string[] args)
        {
            /* 
               PrintPrimitiveValues();
               PersonInitializer();
               CalculatorInitializer();
                Array();
                Enum();
                List();
                DateTime();
            */
            Strings();
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

        static void PersonInitializer()
        {
            Person person = new Person
            {
                FirstName = "John",
                LastName = "Smith"
            };
            person.Introduce();
        }

        static void CalculatorInitializer()
        {
            Calculator calculator = new Calculator();
            var result = calculator.Add(1, 2);
            Console.WriteLine($"The result of sum is {result}");
        }

        static void Array()
        {
            var array = new ExampleArrays.ExampleArrays();
            array.PrintArrayNumbers();
            array.PrintArrayString();
        }

        static void Enum()
        {
            var enumExmaple = new ExampleEnums.ExampleEnums();
            enumExmaple.PrintingEnums();
        }

        static void List()
        {
            var listExample = new ExampleList.ExampleList();
            listExample.Example();
        }

        static void DateTime()
        {
            var dateTimeExample = new ExmapleDateTime.ExampleDateTime();
            dateTimeExample.PrintingDateTime();
        }

        static void Strings()
        {
            var strings = new ExampleString.ExampleString();
            strings.PrintingStrings();
        }
    }
}
