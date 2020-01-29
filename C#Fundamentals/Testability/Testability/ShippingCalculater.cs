namespace Testability
{
    public interface IShippingCalculater
    {
        float CalculateShipping(Order order);
    }
    public class ShippingCalculater: IShippingCalculater
    {
      public float CalculateShipping(Order order)
        {
            if (order.TotalPrice > 30f)
                return order.TotalPrice * 0.1f;

            return 0;
        }
    }
}