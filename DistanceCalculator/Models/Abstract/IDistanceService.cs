using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DistanceCalculator.Models.Abstract
{
    public interface IDistanceService
    {
        Task<string> GetLocationAsync(double lat, double longiude);
        double calculateDistance(double lat1, double lon1, double lat2, double lon2, char unit);
    }
}
