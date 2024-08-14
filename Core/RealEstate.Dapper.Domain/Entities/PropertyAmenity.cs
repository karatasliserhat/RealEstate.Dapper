namespace RealEstate.Dapper.Domain.Entities
{
    public class PropertyAmenity
    {
        public int PropertyAmenityId { get; set; }
        public int ProductId { get; set; }
        public virtual Product Product { get; set; }
        public int AmenityId { get; set; }
        public virtual Amenity Amenity { get; set; }
        public bool Status { get; set; }
    }
}
