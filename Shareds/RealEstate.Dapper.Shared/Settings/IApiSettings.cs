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
        public string EmployeeBaseUrl { get; set; }
        public string StatisticsBaseUrl { get; set; }
        public string ContactBaseUrl { get; set; }
        public string ToDoListBaseUrl { get; set; }
        public string AccountBaseUrl { get; set; }
        public string EstateAgentBaseUrl { get; set; }
        public string MessageBaseUrl { get; set; }
        public string ProductDetailBaseUrl { get; set; }
        public string ProductImageBaseUrl { get; set; }
        public string AppUserBaseUrl { get; set; }
        public string PropertyAmenityBaseUrl { get; set; }

    }
}
