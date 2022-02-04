using System;

namespace AliGulmen.Week4.HomeWork.RestfulApi.Entities
{
    public class Token          
    {
        public string AccessToken { get; set; } //user infos will be here
        public DateTime Expiration { get; set; } //valid until
        public string RefreshToken { get; set; }

    }

}
