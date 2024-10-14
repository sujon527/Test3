

using Analytics.Aggregator.Models;
using Analytics.DTO;
using Analytics.Repository;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Analytics.Handler
{
    public class AnalyticsServiceHandler
    {
        private readonly IAnalyticsDataRepository<AnalyticsData> _analyticsDataRepository;


        public AnalyticsServiceHandler(IAnalyticsDataRepository<AnalyticsData> analyticsDataRepository)
        {
            _analyticsDataRepository = analyticsDataRepository;
        }

        public async Task<AnalyticsDTO> GetAnalyticsDataAsync(int corporateId)
        {

             List<AnalyticsData>data = (await _analyticsDataRepository.GetYourDataAsync(corporateId)).ToList();
            // List<string[]>item=new List<string[]>();

            //foreach(var record in data )
            //{
            //    string[] str = new string[1];
            //    str[0] = record.TmpItemName.ToString();
            //    item.Add(str);
            //}


            var analyticsDto = new AnalyticsDTO();




            //foreach (var record in data)
            //{

            //    analyticsDto = record.ToAnalyticsDTO();
            //}
            var record = new AnalyticsData();
            record.ToAnalyticsDTO(data, analyticsDto);



            return analyticsDto;
        }
        //public async Task<AnalyticsDTO<List<string[]>>> GetAnalyticsDataAsync(string corporateId)
        //{
        //    // Get data from the repository
        //    var analyticsData = await _analyticsDataRepository.GetYourDataAsync(corporateId);

        //    // Return the processed analytics data (already in List<string[]> format)
        //    return;
        //}



    }
}

