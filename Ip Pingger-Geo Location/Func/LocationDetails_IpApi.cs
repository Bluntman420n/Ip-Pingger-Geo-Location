using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ip_Pigger_Geo_Location.Func
{
    public class LocationDetails_IpApi
    {
        public string query { get; set; } // IP
        public string city { get; set; } // City
        public string country { get; set; } // County
        public string countryCode { get; set; } // County CA
        public string isp { get; set; } // ISP
        public double lat { get; set; } // lag
        public double lon { get; set; } // long
        public string org { get; set; } // Orgstaion
        public string region { get; set; } // Region Obreveaion
        public string regionName { get; set; } // Region 
        public string status { get; set; } // True/false
        public string timezone { get; set; } // TimeZone
        public string zip { get; set; } // ZipCode
    }
}
