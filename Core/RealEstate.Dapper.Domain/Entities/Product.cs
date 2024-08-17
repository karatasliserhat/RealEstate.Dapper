namespace RealEstate.Dapper.Domain.Entities
{
    public class Product
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string SlugUrl { get; set; }
        public decimal Price { get; set; }
        public string CoverImage { get; set; }
        public string City { get; set; }
        public string District { get; set; }
        public string Address { get; set; }
        public string Description { get; set; }
        public string Type { get; set; }
        public int CategoryId { get; set; }
        public bool DealOfTheDay { get; set; }
        public DateTime CreatedDate { get; set; }
        public bool Status { get; set; }
        public virtual Category Category { get; set; }
        public int AppUserId { get; set; }
        public virtual AppUser AppUser { get; set; }
        public List<ProductDetail> ProductDetails { get; set; }
        public List<ProductImage> ProductImages { get; set; }
        public virtual List<PropertyAmenity> PropertyAmenities { get; set; }

    }
}
