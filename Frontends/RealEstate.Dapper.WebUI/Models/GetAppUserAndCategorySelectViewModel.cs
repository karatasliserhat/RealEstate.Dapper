using Microsoft.AspNetCore.Mvc.Rendering;

namespace RealEstate.Dapper.WebUI.Models
{
    public class GetAppUserAndCategorySelectViewModel
    {
        public SelectList CategoryList { get; set; }
        public SelectList AppUserList { get; set; }
    }
}
