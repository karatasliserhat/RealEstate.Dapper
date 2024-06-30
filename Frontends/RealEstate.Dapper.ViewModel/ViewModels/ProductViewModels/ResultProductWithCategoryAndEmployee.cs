namespace RealEstate.Dapper.ViewModel.ViewModels
{
    public class ResultProductWithCategoryAndEmployee
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public decimal Price { get; set; }
        public string CoverImage { get; set; }
        public string City { get; set; }
        public string District { get; set; }
        public string Address { get; set; }
        public string CategoryName { get; set; }
        public string EmployeeName { get; set; }
    }
}
