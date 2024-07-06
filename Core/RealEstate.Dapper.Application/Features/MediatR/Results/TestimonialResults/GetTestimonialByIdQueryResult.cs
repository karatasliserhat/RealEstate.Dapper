﻿namespace RealEstate.Dapper.Application.Features.MediatR.Results
{
    public class GetTestimonialByIdQueryResult
    {
        public int Id { get; set; }
        public string NameSurname { get; set; }
        public string Comment { get; set; }
        public string Title { get; set; }
        public bool Status { get; set; }
    }
}
