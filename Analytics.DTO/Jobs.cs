using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Analytics.DTO
{
    public class Jobs
    {
        public int TotalJobs { get; set; }
        public int StandardListingJobs { get; set; }
        public int PremiumListingJobs { get; set; }
        public int HotJobs { get; set; }
    }
}
