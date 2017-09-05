using System;
using System.Configuration;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TasteMakerPull
{
    public class OrganizationSettings
    {
        public static string GetClientID
        {
            get
            {
                return ConfigurationSettings.AppSettings.Get("Client_ID");
            }

        }

        public static string GetClientSecret
        {
            get
            {
                return ConfigurationSettings.AppSettings.Get("Client_Secret");
            }

        }
    }
}
