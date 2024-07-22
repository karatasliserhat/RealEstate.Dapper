﻿namespace RealEstate.Dapper.WebAPI.Tools
{
    public interface IJwtTokenModel
    {
        public string Audience { get; set; }
        public string Issuer { get; set; }
        public string Key { get; set; }
        public int ExpireDate { get; set; }
    }
}
