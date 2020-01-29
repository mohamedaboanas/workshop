using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Amazon
{
    public class Suppliers
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public void Promote()
        {
            var calculate = new RateCalculator();
            var rating = calculate.Calculate(this);




        }
    }
}
