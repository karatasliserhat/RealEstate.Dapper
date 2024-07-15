using Microsoft.AspNetCore.Mvc.Rendering;
using RealEstate.Dapper.Shared.Abstract.IApiReadService;
using RealEstate.Dapper.WebUI.Models;

namespace RealEstate.Dapper.WebUI.Tools
{
    public class GetEmployeeAndCategorySelectList
    {
        private readonly ICategoryReadApiService _categoryReadApiService;
        private readonly IEmployeeReadApiService _employeeReadApiService;

        public GetEmployeeAndCategorySelectList(ICategoryReadApiService categoryReadApiService, IEmployeeReadApiService employeeReadApiService)
        {
            _categoryReadApiService = categoryReadApiService;
            _employeeReadApiService = employeeReadApiService;
        }

        public async Task<GetEmployeAndCategorySelectViewModel> EmployeeAndCategorySelectList(int categoryId = 0, int employeeId = 0)
        {
            var categoryValues = await _categoryReadApiService.GetListAsync();
            SelectList categorySlectList = categoryId > 0 ? new SelectList(categoryValues, "Id", "CategoryName", categoryId) : new SelectList(categoryValues, "Id", "CategoryName");

            var employeValues = await _employeeReadApiService.GetListAsync();
            SelectList employeeSelectList = employeeId > 0 ? new SelectList(employeValues, "Id", "EmployeeName", employeeId) : new SelectList(employeValues, "Id", "EmployeeName");
            return new GetEmployeAndCategorySelectViewModel { CategoryList = categorySlectList, EmployeeList = employeeSelectList };
            //List<SelectListItem> SelectListItem = (from x in categoryValues.ToList()
            //                                 select new SelectListItem
            //                                 {
            //                                     Text = x.CategoryName,
            //                                     Value = x.Id.ToString()
            //                                 }).ToList();

        }
    }
}
