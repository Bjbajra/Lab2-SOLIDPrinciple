using Lab2_SOLIDPattern.Repositories;

namespace Lab2_SOLIDPattern.Services
{
    public interface IOrderService
    {
        void OrderProcess(IOrderRepo order);
    }
}
