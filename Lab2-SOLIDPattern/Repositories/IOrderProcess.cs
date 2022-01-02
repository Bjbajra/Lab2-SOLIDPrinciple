namespace Lab2_SOLIDPattern.Repositories
{
    public interface IOrderProcess
    {
        bool Process(IOrderRepo order);
    }
}
