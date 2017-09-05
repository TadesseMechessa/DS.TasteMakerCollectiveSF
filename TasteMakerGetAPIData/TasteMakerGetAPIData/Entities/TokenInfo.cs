using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TasteMakerPull.Entities
{
  public  class TokenInfo
    {
        public class Application
        {
            public string uid { get; set; }
        }

        public class RootObject
        {
            public string resource_owner_id { get; set; }
            public string scopes { get; set; }
            public int expires_in_seconds { get; set; }
            public Application application { get; set; }
            public long created_at { get; set; }
        }
    }
}
