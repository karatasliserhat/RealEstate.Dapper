namespace RealEstate.Dapper.Domain.Entities
{
    public class ProductDetail
    {
        public int Id { get; set; }
        public int Size { get; set; }
        public int BedRoomCount { get; set; }
        public int RoomCount { get; set; }
        public int GarageSize { get; set; }
        public char BuildYear { get; set; }
        public decimal Price { get; set; }
        public string Location { get; set; }
        public string VideoUrl { get; set; }
        public List<Product> Products { get; set; }
    }
}
