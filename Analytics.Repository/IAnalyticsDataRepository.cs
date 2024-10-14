
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Analytics.Repository
{
    public interface IAnalyticsDataRepository<T> where T:class
    {
       Task <IEnumerable<T>> GetYourDataAsync(int corporateId);

    }
}
