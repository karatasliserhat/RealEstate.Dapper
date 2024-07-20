﻿namespace RealEstate.Dapper.Domain.Entities
{
    public class AppUser
    {
        public int UserId { get; set; }
        public string Name { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }
        public int RoleId { get; set; }
        public AppRole AppRole { get; set; }
    }
}
