

using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using Analytics.Handler;
using Analytics.DTO;
using System.Collections.Generic; // Ensure you have this for IEnumerable
using System.Linq; // Ensure you have this for .Any()

namespace Analytics.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class AnalyticsController : ControllerBase
    {
        private readonly AnalyticsServiceHandler _analyticsServiceHandler;

        public AnalyticsController(AnalyticsServiceHandler analyticsServiceHandler)
        {
            _analyticsServiceHandler = analyticsServiceHandler;
        }

        [HttpGet("GetAnalytics/{corporateId}")]
        public async Task<IActionResult> GetAnalyticsDataAsync(string corporateId)
        {
            if (string.IsNullOrEmpty(corporateId))
            {
                return BadRequest("Corporate ID cannot be null or empty.");
            }



            var analyticsData = await _analyticsServiceHandler.GetAnalyticsDataAsync(corporateId);


            // Console.WriteLine("Genders Count: " + analyticsData.genders);

            return Ok(analyticsData);
        }


    }
}

