using Lab2_SOLIDPattern.Repositories;

namespace Lab2_SOLIDPattern.Entities
{
    public class OrderProcessNormally : IOrderProcess
    {
        public bool Process(IOrderRepo order)
        {
            // Some logic we don't care about,
            return true;
        }
    }
}
