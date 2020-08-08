using System;
using System.Collections.Generic;
using System.Text;

namespace ShopApi.Models
{
    public class ApiLoginResponce
    {
        public string access_token { get; set; }
        public int expires_in { get; set; }
        public string token_type { get; set; }
    }
}
