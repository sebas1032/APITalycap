using System.Net;

namespace APITalycap.Models
{
    public class ApiExterna
    {
        public string GetApiExterna(string endpoint)
        {
            string responseBody = "";
            var url = $"https://fakerestapi.azurewebsites.net/api/v1/";
            var request = (HttpWebRequest)WebRequest.Create(url + endpoint);
            request.Method = "GET";
            request.ContentType = "application/json";
            request.Accept = "application/json";

            using (WebResponse response = request.GetResponse())
            {
                using (Stream strReader = response.GetResponseStream())
                {
                    if (strReader == null) return "";
                    using (StreamReader objReader = new StreamReader(strReader))
                    {
                        responseBody = objReader.ReadToEnd();
                        // Do something with responseBody
                        Console.WriteLine(responseBody);
                    }
                }
            }
            return responseBody;
        }
    }
}