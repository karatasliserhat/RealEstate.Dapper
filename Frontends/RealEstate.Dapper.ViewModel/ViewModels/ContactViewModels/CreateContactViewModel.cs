namespace RealEstate.Dapper.ViewModel.ViewModels
{
    public class CreateContactViewModel
    {
        public string Name { get; set; }
        public string Subject { get; set; }
        public string Email { get; set; }
        public string Message { get; set; }
        public DateTime SendDate { get; set; }
    }
}
