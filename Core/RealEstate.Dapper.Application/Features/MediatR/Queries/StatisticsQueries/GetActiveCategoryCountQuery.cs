using MediatR;
using RealEstate.Dapper.Application.Features.MediatR.Results;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RealEstate.Dapper.Application.Features.MediatR.Queries
{
    public class GetActiveCategoryCountQuery:IRequest<GetActiveCategoryCountQueryResult>
    {
    }
}
