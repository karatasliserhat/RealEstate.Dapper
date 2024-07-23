namespace RealEstate.Dapper.Shared.Settings
{
    public class ApiSettings : IApiSettings
    {
        public string CategoryBaseUrl { get ; set; }
        public string ProductBaseUrl { get ; set;  }
        public string AboutDetailBaseUrl { get ; set;  }
        public string AboutServiceBaseUrl { get ; set;  }
        public string StepsGridBaseUrl { get ; set;  }
        public string PopulerLocationBaseUrl { get ; set;  }
        public string TestimonialBaseUrl { get ; set;  }
        public string EmployeeBaseUrl { get; set; }
        public string StatisticsBaseUrl { get; set; }
        public string ContactBaseUrl { get; set; }
        public string ToDoListBaseUrl { get; set; }
        public string AccountBaseUrl { get; set; }
        public string EstateAgentBaseUrl { get; set; }
    }
}
