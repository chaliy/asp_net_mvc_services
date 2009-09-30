using Example.Services.OrderPorcessing;
using Example.Application;
namespace Example.Tests
{
    public class When_order_promoted
    {
        public void Should_change_status()
        {
            var processing = new OrderPorcessingController();
            var result = processing.PromoteOrder("TestOrder");
            //Assert.Equals(OrderStatus.Promoted, result.NewStatus);
        }
    }
}