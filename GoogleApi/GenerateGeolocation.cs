using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net;
using System.IO;
using System.Web.Script.Serialization;

using GoogleApi.DataTypesGeolocation;

namespace GoogleApi
{
    public static class GenerateGeolocation
    {
        public static Dictionary<string, string> GetGeoloacation(string origin, string key)
        {
            Dictionary<string, string> result = new Dictionary<string, string>();
            if (!string.IsNullOrEmpty(origin))
            {
                
                try
                {
                    string apiUrl = "https://maps.googleapis.com/maps/api/geocode/json?address={0}&key={1}";
                    apiUrl = string.Format(apiUrl, origin, key);
                    WebRequest request = HttpWebRequest.Create(apiUrl);
                    WebResponse response = request.GetResponse();
                    StreamReader reader = new StreamReader(response.GetResponseStream());
                    JavaScriptSerializer parser = new JavaScriptSerializer();
                    string responseStringData = reader.ReadToEnd();
                    RootObject responseData = parser.Deserialize<RootObject>(responseStringData);
                    if (responseData != null)
                    {
                        Result _result = responseData.results[0];
                        result.Add("formatted_address", _result.formatted_address);
                        result.Add("lat", _result.geometry.location.lat.ToString());
                        result.Add("lng", _result.geometry.location.lng.ToString());
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
            return result;
        }
    }
}
