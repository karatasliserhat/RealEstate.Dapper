using MediatR;
using RealEstate.Dapper.Application.Features.MediatR.Results;

namespace RealEstate.Dapper.Application.Features.MediatR.Queries
{
    public class GetProductByIdWithCategoryAndAppUserQuery:IRequest<GetProductByIdWithCategoryAndAppUserQueryResult>
    {
        public int Id { get; set; }

        public GetProductByIdWithCategoryAndAppUserQuery(int id)
        {
            Id = id;
        }
    }
}
