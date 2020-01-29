using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reflactor
{
    [Role("Admin")]
    public class Mathmatics
    {
        [Role("Admin")]
        public int Sum(int x, int y)
        {
            return x + y;
        }

        [Role("Admin")]
        public int Substract(int x, int y)
        {
            return x - y;
        }

        [Role("Admin")]
        public int Divid(int x, int y)
        {
            return x / y;
        }

        [Role("Admin")]
        public int Multiply(int x, int y)
        {
            return x * y;
        }
    }


}
