using System;

namespace CSharpFundamentals.ExmapleDateTime
{
    public class ExampleDateTime
    {
        public void PrintingDateTime()
        {
            var datetime = new DateTime();
            var datetimeCustom = new DateTime(2020, 01, 01);
            var now = DateTime.Now;
            var nowUTC = DateTime.UtcNow;
            Console.WriteLine($"datetime: {datetime} \ndatetimeCustom: {datetimeCustom}" +
                $"\nnow:{now}\nnowUTC: {nowUTC}");
        }
    }
}
