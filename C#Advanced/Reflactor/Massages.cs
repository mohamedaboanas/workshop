using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Reflactor
{
    [Role("Admin")]
    public class Massages
    {
        [Role("Admin")]
        public string Hello()
        {
            return "Hello";
        }

        [Role("Admin")]
        public string GetName(string name)
        {
            return "Hello" + name;
        }
    }
}
