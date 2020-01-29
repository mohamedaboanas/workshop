
using System;

namespace CAdvanced
{
    public class EnumFlageAttribute
    {
        [Flags]
        public enum FontStyle
        {
            Bold = 1,
            Italic = 1 << 1,
            UnderLinw = 1 << 2

        }
    }
}
