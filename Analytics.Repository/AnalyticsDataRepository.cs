using System;
using Dapper;

using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Analytics.Repository
{
    public class AnalyticsDataRepository<T> : IAnalyticsDataRepository<T> where T : class
    {
        private readonly IDbConnection _dbConnection;

        public AnalyticsDataRepository(IDbConnection dbConnection)
        {
            _dbConnection = dbConnection;
        }

        public async Task<IEnumerable<T>> GetYourDataAsync(string corporateId)
        {

            var query = "SELECT * FROM AnalyticsData WHERE CP_ID = @CorporateId"; // Adjust the query according to your schema

            var list = await _dbConnection.QueryAsync<T>(query, new { CorporateId = corporateId });
            return list;
        }
    }
}
