namespace Lab2_SOLIDPattern.Repositories
{
    public interface IOrderRepo
    {
        public Guid ID { get; set; }
        public int TotalPrce { get; set; }
        public string Email { get; set; }
        public IOrderProcess Priority { get; set; }
    }
}
