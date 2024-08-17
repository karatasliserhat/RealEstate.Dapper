namespace RealEstate.Dapper.Shared.Settings
{
    public interface IApiSettings
    {
        string CategoryBaseUrl { get; set; }
        string ProductBaseUrl { get; set; }
        string AboutDetailBaseUrl { get; set; }
        string AboutServiceBaseUrl { get; set; }
        string StepsGridBaseUrl { get; set; }
        string PopulerLocationBaseUrl { get; set; }
        string TestimonialBaseUrl { get; set; }
        string EmployeeBaseUrl { get; set; }
        string StatisticsBaseUrl { get; set; }
        string ContactBaseUrl { get; set; }
        string ToDoListBaseUrl { get; set; }
        string AccountBaseUrl { get; set; }
        string EstateAgentBaseUrl { get; set; }
        string MessageBaseUrl { get; set; }
        string ProductDetailBaseUrl { get; set; }
        string ProductImageBaseUrl { get; set; }
        string AppUserBaseUrl { get; set; }
        string PropertyAmenityBaseUrl { get; set; }
        string SubFeatureBaseUrl { get; set; }

    }
}
