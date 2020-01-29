using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld
{
    public class Customer
    {
        public int Id;
        public string Name;
        public List<Order> Orders;

        //another way to initialise the list of order and we do not need to put it in the constructor
        //public List<Order> Orders = new List<Order>();

        // ReadOnly assigned only once
        //public readonly List<Order> Orders = new List<Order>();

        public Customer()
        {
            Orders = new List<Order>();
        }

        public Customer(int id)
            : this()
        {
            this.Id = id;
        }

        public Customer(int id, string name)
            : this(id)
        {
            this.Name = name;
        }

        public void Promote()
        {
            var result = CalculateRang(excludeOrders: true);

            if(result == 0)
                Console.WriteLine("Customer was promoted.");

            else
                Console.WriteLine("Customer was nor promoted.");
               


            // if the initialise with readolny it will be give an error
            //Orders = new List<Order>();
            // .......

        }

        private int CalculateRang(bool excludeOrders)
        {
            return 0;
        }
    }
}
