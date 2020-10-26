using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpFundamentals.ExampleEnums
{
    class ExampleEnums
    {
        public enum ShippingMethod
        {
            RegularAirMail = 1,
            RegiteredAirEmail = 2,
            Express = 3
        }

        public void PrintingEnums()
        {
            var method = ShippingMethod.Express;
            Console.WriteLine(method);
        }
    }
}
