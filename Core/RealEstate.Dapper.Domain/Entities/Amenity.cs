namespace RealEstate.Dapper.Domain.Entities
{
    public class Amenity
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public virtual List<PropertyAmenity> PropertyAmenities { get; set; }
    }
}
