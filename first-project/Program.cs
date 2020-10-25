using System;

namespace first_project
{
    class Program
    {
        static void Main(string[] args)
        {
            PrintPrimitiveValues();
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
