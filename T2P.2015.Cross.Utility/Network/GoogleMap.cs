using Google.Api.Maps.Service;
using Google.Api.Maps.Service.Geocoding;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T2P._2015.Cross.Utility.Network
{
    public class GoogleMap
    {
        public static dynamic GetLatitudeLongitude(string addess)
        {
            Geometry geometry = new Geometry();
            var request = new GeocodingRequest();
            request.Address = addess;
            request.Sensor = "false";
            var response = GeocodingService.GetResponse(request);
            if (response.Status == ServiceResponseStatus.Ok)
            {
                GeocodingResult[] geo = response.Results;
                if (response.Results.Length == 1)
                {
                    geometry = geo[0].Geometry;
                }
            }
            return geometry;
        }
    }
}
