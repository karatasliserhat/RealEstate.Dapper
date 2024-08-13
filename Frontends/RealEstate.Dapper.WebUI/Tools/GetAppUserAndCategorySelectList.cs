using Microsoft.AspNetCore.Mvc.Rendering;
using RealEstate.Dapper.Shared.Abstract.IApiReadService;
using RealEstate.Dapper.WebUI.Models;

namespace RealEstate.Dapper.WebUI.Tools
{
    public class GetAppUserAndCategorySelectList
    {
        private readonly ICategoryReadApiService _categoryReadApiService;
        private readonly IAppUserReadApiService _appUserReadApiService;

        public GetAppUserAndCategorySelectList(ICategoryReadApiService categoryReadApiService, IAppUserReadApiService appUserReadApiService)
        {
            _categoryReadApiService = categoryReadApiService;
            _appUserReadApiService = appUserReadApiService;
        }

        public async Task<GetAppUserAndCategorySelectViewModel> EmployeeAndCategorySelectList(int categoryId = 0, int appUserId = 0)
        {
            var categoryValues = await _categoryReadApiService.GetListAsync();
            SelectList categorySlectList = categoryId > 0 ? new SelectList(categoryValues, "Id", "CategoryName", categoryId) : new SelectList(categoryValues, "Id", "CategoryName");

            var appUserValues = await _appUserReadApiService.GetListAsync("GetAppUserList");
            SelectList appUserListSelectList = appUserId > 0 ? new SelectList(appUserValues, "UserId", "Name", appUserId) : new SelectList(appUserValues, "UserId", "Name");
            return new GetAppUserAndCategorySelectViewModel { CategoryList = categorySlectList, AppUserList = appUserListSelectList };
            //List<SelectListItem> SelectListItem = (from x in categoryValues.ToList()
            //                                 select new SelectListItem
            //                                 {
            //                                     Text = x.CategoryName,
            //                                     Value = x.Id.ToString()
            //                                 }).ToList();

        }
    }
}
