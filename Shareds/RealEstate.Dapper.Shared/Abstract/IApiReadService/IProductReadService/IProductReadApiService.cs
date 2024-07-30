﻿using RealEstate.Dapper.ViewModel.ViewModels;

namespace RealEstate.Dapper.Shared.Abstract.IApiReadService.IProductReadService
{
    public interface IProductReadApiService:IBaseReadApiService<ResultProductViewModel>
    {
        Task<List<ResultProductWithCategoryAndEmployee>> GetListProductWithCategoryAndEmployeeAsync();
        Task<List<ResultProductWithCategoryAndEmployee>> GetListLastProductAsync(int HowProductCount);
        Task<List<ResultProductWithCategoryAndEmployee>> GetListLastProductAsync(int HowProductCount,int UserId);
        Task<List<ResultProductWithCategoryAndEmployee>> GetListProductByUserAsync(int UserId);
    }
}
