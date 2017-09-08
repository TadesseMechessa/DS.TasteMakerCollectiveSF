using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TasteMakerPull.Entities
{   
    [Serializable]
    public class CurrentUser
    {
        [JsonProperty(PropertyName = "id")]
        public string id { get; set; }
    }
    //public class CurrentUser
    //{
    //    [JsonProperty(PropertyName = "id")]
    //    public string Id { get; set; }

    //public CurrentUser(string Id)
    //{
    //    id = Id;
    //}

    //public string id { get; set; }
    //public string slug { get; set; }
    //public string first_name { get; set; }
    //public string last_name { get; set; }
    //public string created_at { get; set; }
    //public string updated_at { get; set; }
    //public string email { get; set; }
    //}

}
