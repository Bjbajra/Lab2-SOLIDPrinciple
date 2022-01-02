namespace Lab2_SOLIDPattern.Repositories
{
    public class LogMessagesRepo : ILogMessagesRepo
    {
        public void LogMessage(string message)
        {
            Console.WriteLine($"{DateTime.Now}: {message}");
        }
    }
}
