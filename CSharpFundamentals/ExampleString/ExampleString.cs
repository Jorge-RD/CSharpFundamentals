using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpFundamentals.ExampleString
{
    public class ExampleString
    {
        public void ConvertingString ()
        {
            int number = 1234;
            string convertToString = number.ToString();
            string convertToStringC = number.ToString("C");
            string convertToStringC0 = number.ToString("C0");
            Console.WriteLine($"" +
                $"Result of ToString empty: {convertToString} \n\n" +
                $"convert 'C' to String: {convertToStringC} \n\n" +
                $"convert 'C0' to String: {convertToStringC0}");
        }
        public void PrintingStrings()
        {
            ConvertingString();
        }
    }
}
