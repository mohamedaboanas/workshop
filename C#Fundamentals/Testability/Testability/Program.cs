using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Testability
{
    class Program
    {
        static void Main(string[] args)
        {
            var orderprocessor = new OrderProcessor(new ShippingCalculater());
            var order = new Order
            {
                DatePlaced = DateTime.Now,
                TotalPrice = 100f
            };

            orderprocessor.Process(order);

           
        }
    }
}
