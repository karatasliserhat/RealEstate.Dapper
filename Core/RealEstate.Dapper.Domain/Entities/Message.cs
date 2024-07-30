namespace RealEstate.Dapper.Domain.Entities
{
    public class Message
    {
        public int Id { get; set; }
        public int Sender { get; set; }
        public int Receive { get; set; }
        public string Subject { get; set; }
        public string Detail { get; set; }
        public DateTime SendDate { get; set; }
        public bool IsRead { get; set; }

        public virtual AppUser SenderUser { get; set; }
        public virtual AppUser ReceiveUser { get; set; }
    }
}
