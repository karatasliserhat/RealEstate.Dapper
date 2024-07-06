﻿namespace RealEstate.Dapper.Application.Features.MediatR.Results
{
    public class GetPopulerLocationQueryResult
    {
        public int Id { get; set; }
        public string CityName { get; set; }
        public string ImageUrl { get; set; }
        public bool Status { get; set; }
    }
}
