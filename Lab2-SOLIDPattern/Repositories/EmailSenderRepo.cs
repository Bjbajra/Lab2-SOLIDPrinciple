namespace Lab2_SOLIDPattern.Repositories
{
    public class EmailSenderRepo : IEmailSenderRepo
    {
        public string SendEmail(string email, Guid ID)
        {
            // Some email sending logic we don't care about
            return $"Notification sent to email {email} for order {ID}";
        }
    }
}
