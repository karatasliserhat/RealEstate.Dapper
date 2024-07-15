using Microsoft.AspNetCore.Mvc.Rendering;

namespace RealEstate.Dapper.WebUI.Models
{
    public class GetEmployeAndCategorySelectViewModel
    {
        public SelectList CategoryList { get; set; }
        public SelectList EmployeeList { get; set; }
    }
}
