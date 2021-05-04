using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Pos.Api.Models
{
    [JsonObject]
    public class ApiResponse
    {
        public ApiResponse() 
        {
            Payload = new Dictionary<string, object>();
        }
        public bool Result { get; set; }
        public string Message { get; set; }
        public Dictionary<string, object> Payload { get; set; }
    }
}
