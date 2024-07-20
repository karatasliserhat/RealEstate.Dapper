namespace RealEstate.Dapper.Domain.Entities
{
    public class AppRole
    {
        public int RoleId { get; set; }
        public string RoleName { get; set; }
        public virtual List<AppUser> AppUsers { get; set; }
    }
}
