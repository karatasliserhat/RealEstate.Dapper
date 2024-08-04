namespace RealEstate.Dapper.ViewModel.ViewModels
{
    public class ResultProductAndDetailListViewModel
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public decimal Price { get; set; }
        public string CoverImage { get; set; }
        public string City { get; set; }
        public string District { get; set; }
        public string Type { get; set; }
        public string Address { get; set; }
        public string CategoryName { get; set; }
        public string EmployeeName { get; set; }
        public string Description { get; set; }
        public DateTime CreatedDate { get; set; }
        public int Size { get; set; }
        public int BedRoomCount { get; set; }
        public int RoomCount { get; set; }
        public int GarageSize { get; set; }
        public int BuildYear { get; set; }
        public string Location { get; set; }
        public string VideoUrl { get; set; }
        public bool Status { get; set; }
        public string DataProtect { get; set; }
    }
}
