namespace RealEstate.Dapper.ViewModel.ViewModels
{
    public class ResultInBoxMessage
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Subject { get; set; }
        public string Detail { get; set; }
        public DateTime SendDate { get; set; }
        public string ImageUrl { get; set; }
        public bool IsRead { get; set; }
    }
}
