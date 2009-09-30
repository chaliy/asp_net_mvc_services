namespace Example.Application
{
    public class Order
    {

        public OrderStatus Status { get; internal set; }

        public void PromoteOrder()
        {
            // Some unbellivable logic goes here...
            Status = OrderStatus.Promoted;
        }
    }
}
