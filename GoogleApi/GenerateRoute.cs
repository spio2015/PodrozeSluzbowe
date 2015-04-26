using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net;
using System.IO;
using System.Web.Script.Serialization;

namespace GoogleApi
{    
    public static class GenerateRoute
    {
        public static Dictionary<string, string> GetDistance(string origin, string destination, string key)
        {
            Dictionary<string, string> result = new Dictionary<string, string>();
            try
            {
                string apiUrl = "https://maps.googleapis.com/maps/api/directions/json?origin={0},&destination={1}&sensor=false&key={2}";
                apiUrl = string.Format(apiUrl, origin, destination, key);
                WebRequest request = HttpWebRequest.Create(apiUrl);
                WebResponse response = request.GetResponse();
                StreamReader reader = new StreamReader(response.GetResponseStream());
                JavaScriptSerializer parser = new JavaScriptSerializer();
                string responseStringData = reader.ReadToEnd();
                RootObject responseData = parser.Deserialize<RootObject>(responseStringData);
                if (responseData != null)
                {
                    Leg leg = responseData.routes[0].legs[0];
                    result.Add("start_address", leg.start_address);
                    result.Add("start_location_lat", leg.start_location.lat.ToString().Replace(',', '.'));
                    result.Add("start_location_lng", leg.start_location.lng.ToString().Replace(',', '.'));
                    result.Add("end_address", leg.end_address);
                    result.Add("end_location_lat", leg.end_location.lat.ToString().Replace(',', '.'));
                    result.Add("end_location_lng", leg.end_location.lng.ToString().Replace(',', '.'));
                    result.Add("distance", leg.distance.text);
                    result.Add("duration", leg.duration.text);                    
                    double distance = responseData.routes.Sum(r => r.legs.Sum(l => l.distance.value));
                    if (distance == 0)
                    {
                        throw new Exception("Google cannot find road route");
                    }
                    return result;
                }
                else
                {
                    throw new Exception("Unable to get location from google");                    
                }

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
