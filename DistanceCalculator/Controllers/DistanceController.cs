using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DistanceCalculator.Models.Abstract;
using DistanceCalculator.Models.Entity;
using Microsoft.AspNetCore.Mvc;

namespace DistanceCalculator.Controllers
{
    [Produces("application/json")]
    public class DistanceController : Controller
    {
        private readonly IDistanceService _distanceService;
        public DistanceController(IDistanceService distanceService)
        {
            this._distanceService = distanceService;
        }
        [HttpGet]
        [Route("api/distance")]
        public async Task<Result> Index([FromQuery] double lat1, [FromQuery] double long1, [FromQuery] double lat2, [FromQuery] double long2)
        {
            string city1 = await this._distanceService.GetLocationAsync(lat1, long1);
            string city2 = await this._distanceService.GetLocationAsync(lat2, long2);
            double distance = this._distanceService.calculateDistance(lat1,long1,lat2,long2,'K');
            Result result = new Result()
            {
                location1 = city1,
                location2 = city2,
                distance = distance
            };
            return result;
        }
    }
}