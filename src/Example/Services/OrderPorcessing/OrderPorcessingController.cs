namespace Example.Services.OrderPorcessing
{
    using Community.Web.Mvc.Services;
    using Example.Application;

    public class OrderPorcessingController : ServiceController
    {
        public OrderPromotionResult PromoteOrder(string orderNumber)
        {
            var orders = new OrderRepository();
            var order = orders.GetOrderByNumber(orderNumber);

            order.PromoteOrder();

            return new OrderPromotionResult
            {
                NewStatus = order.Status
            };
        }
    }
}