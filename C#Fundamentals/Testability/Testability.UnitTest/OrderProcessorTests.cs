using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Testability.UnitTest
{
    [TestClass]
    public class OrderProcessorTests
    {
        // MethodName_Condition_Expectation
        [TestMethod]
        [ExpectedException(typeof(InvalidOperationException))]
        public void Process_OrderIsAlreadyShipped_ThrowsException()
        {
            var orderProcessor = new OrderProcessor(new FakeShippingCalculator());

            var order = new Order
            {
                Shipment = new Shipment()
            };

            orderProcessor.Process(order);
        }

        [TestMethod]
        public void Process_OrderIsNotShipped_ShouldSetTheShipmentPropertyOfTheOrder()
        {
            var orderProcessor = new OrderProcessor(new FakeShippingCalculator());
            var order = new Order();

            orderProcessor.Process(order);

            Assert.IsTrue(order.IsShipped);
        }
    }

    public class FakeShippingCalculator : IShippingCalculater
    {
        public float CalculateShipping(Order order)
        {
            return 1;
        }
    }
}
