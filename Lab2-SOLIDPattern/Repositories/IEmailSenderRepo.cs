namespace Lab2_SOLIDPattern.Repositories
{
    public interface IEmailSenderRepo
    {
        string SendEmail(string email, Guid ID);
    }
}
