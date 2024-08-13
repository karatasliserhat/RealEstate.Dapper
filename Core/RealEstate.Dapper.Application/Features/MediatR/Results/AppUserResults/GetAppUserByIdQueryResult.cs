﻿namespace RealEstate.Dapper.Application.Features.MediatR.Results
{
    public class GetAppUserByIdQueryResult
    {
        public int UserId { get; set; }
        public string Name { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        public string ImageUrl { get; set; }
    }
}
