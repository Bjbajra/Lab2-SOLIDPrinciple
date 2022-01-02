using Lab2_SOLIDPattern.Services;

namespace Lab2_SOLIDPattern.Repositories
{
    public static class OrderFactory
    {
        public static ILogMessagesRepo CreateLogMessages()
        {
            return new LogMessagesRepo();
        }
        public static IEmailSenderRepo CreateEmailSender()
        {
            return new EmailSenderRepo();
        }
        public static IOrderService CreateOrderService()
        {
            return new OrderService(CreateLogMessages(), CreateEmailSender());
        }
        public static IOrderRepo CreateNormalOrder()
        {
            return new NormalOrderRepo();
        }
        public static IOrderRepo CreateQuickOrder()
        {
            return new QuickOrderRepo();
        }
        public static IOrderRepo CreateOrderInLightningSpeed()
        {
            return new LightningSpeedOrderRepo();
        }
    }
}
