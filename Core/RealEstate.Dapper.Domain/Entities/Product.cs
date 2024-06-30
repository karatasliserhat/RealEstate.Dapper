namespace RealEstate.Dapper.Domain.Entities
{
    public class Product
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public decimal Price { get; set; }
        public string CoverImage { get; set; }
        public string City { get; set; }
        public string District { get; set; }
        public string Address { get; set; }
        public string Description { get; set; }
        public int CategoryId { get; set; }
        public virtual Category Category { get; set; }
        public int EmployeeId { get; set; }
        public virtual Employee Employee { get; set; }
        public List<ProductDetail> ProductDetails { get; set; }

    }
}
