namespace RealEstate.Dapper.Shared.Settings
{
    public interface IApiSettings
    {
        string CategoryBaseUrl { get; set; }
        string ProductBaseUrl { get; set; }
        string AboutDetailBaseUrl { get; set; }
        string AboutServiceBaseUrl { get; set; }
        string StepsGridBaseUrl { get; set; }

    }
}
