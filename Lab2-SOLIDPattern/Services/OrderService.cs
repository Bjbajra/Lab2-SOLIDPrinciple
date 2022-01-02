using Lab2_SOLIDPattern.Repositories;

namespace Lab2_SOLIDPattern.Services
{
    public class OrderService : IOrderService
    {
        private readonly ILogMessagesRepo _logMessages;
        private readonly IEmailSenderRepo _emailSender;

        public OrderService(ILogMessagesRepo logMessages, IEmailSenderRepo emailSender)
        {
            _logMessages = logMessages;
            _emailSender = emailSender;
        }
        public void OrderProcess(IOrderRepo order)
        {
            bool isProcessed = false;

            _logMessages.LogMessage($"Attempting to process order with ID {order.ID}");
            isProcessed = order.Priority.Process(order);

            if (isProcessed)
            {
                _logMessages.LogMessage($"Succesfully processed order with ID {order.ID}");
                Console.WriteLine(_emailSender.SendEmail(order.Email, order.ID));
            }
            else
            {
                _logMessages.LogMessage($"FAILED ORDER: Could not ship order with ID {order.ID}");
            }
        }
    }
}
