using System;

namespace Testability
{
    public class OrderProcessor
    {
        private readonly IShippingCalculater _shippingCalculater;

        public OrderProcessor(IShippingCalculater shippingCalculater)
        {
            _shippingCalculater = shippingCalculater;
        }

        public void Process(Order order)
        {
            if(order.IsShipped)
                throw new InvalidOperationException("This order is already processed.");

            order.Shipment = new Shipment
            {
                Cost = _shippingCalculater.CalculateShipping(order),
                ShippingDate = DateTime.Today.AddDays(1)
            };

        }
    }
}