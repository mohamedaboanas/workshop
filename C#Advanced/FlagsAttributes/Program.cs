using System;

namespace FlagsAttributes
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("All possible combinations of value without flags attributes");

            for (int i = 0; i <= 16; i++)
            {
                Console.WriteLine("{0,3} - {1:G}", i, (EnumFlags.SingleHue)i);

            }


            Console.WriteLine("All possible combinations of value with Flags Attributes");

            for (int i = 0; i <= 16; i++)
            {
                Console.WriteLine("{0,3} - {1:G}", i, (EnumFlags.MultiHue)i);

            }
        }
    }
}
