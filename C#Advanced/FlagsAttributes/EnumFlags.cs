using System;

namespace FlagsAttributes
{
    public class EnumFlags
    {
        public enum SingleHue : short
        {
            None = 0,
            Black = 1,
            Red = 2,
            Green = 3,
            Blue = 4

        }

        [Flags]
        public enum MultiHue : short
        {
            None = 0,
            Black = 1,
            Red = 2,
            Green = 4,
            Blue = 8
        }
    }
}
