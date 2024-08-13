﻿using RealEstate.Dapper.Shared.Abstract.IApiReadService;
using RealEstate.Dapper.ViewModel.ViewModels;

namespace RealEstate.Dapper.Shared.Services.ApiReadService
{
    public class AppUserReadApiService : BaseReadApiService<ResultAppUserViewModel>, IAppUserReadApiService
    {
        public AppUserReadApiService(HttpClient httpClient) : base(httpClient)
        {
        }
    }
}
