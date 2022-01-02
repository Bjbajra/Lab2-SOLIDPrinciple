using Lab2_SOLIDPattern.Entities;

namespace Lab2_SOLIDPattern.Repositories
{
    public class QuickOrderRepo :IOrderRepo
    {
        public Guid ID { get; set; }
        public int TotalPrce { get; set; }
        public string Email { get; set; }
        public IOrderProcess Priority { get; set; } = new OrderProcessQuickly();
    }
}
