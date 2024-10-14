using Analytics.Handler;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace AnalyticsReport.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AnalyticsReportController : ControllerBase
    {
        
        private readonly AnalyticsServiceHandler _analyticsServiceHandler;

        public AnalyticsReportController(AnalyticsServiceHandler analyticsServiceHandler)
        {
            _analyticsServiceHandler = analyticsServiceHandler;
        }


        //public ActionResult<AnalyticsDTO> GetAnalyticsData( string corporateId)
        //{
        //    var analyticsData = _analyticsServiceHandler.GetAnalyticsDataAsync(corporateId); // Fetch data using the handler

        //    if (analyticsData == null)
        //    {
        //        return NotFound(); // Return 404 if no data found
        //    }

        //    return Ok(analyticsData); // Return the DTO data with 200 OK
        //}
        [HttpGet]
        public async Task<ActionResult<AnalyticsDTO>> GetAnalyticsData(int corporateId)
        {
            var data = await _analyticsServiceHandler.GetAnalyticsDataAsync(corporateId);
            return Ok(data);  // This returns the properly serialized DTO
        }
    }
}
