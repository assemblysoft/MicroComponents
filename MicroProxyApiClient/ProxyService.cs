using Newtonsoft.Json;
using SharedLibrary.ViewModels;
using System;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;

namespace MicroProxyApiClient
{
    public class ProxyService //IProxy....
    {
        private readonly HttpClient _httpClient = new HttpClient();

        public async Task<WeatherForecastViewModel> GetViewModel()
        {           

            try
            {
                var configStored_WeatherForecastUri = $"https://localhost:44341/weatherforecast/WeatherForecastViewModel"; //ensure api is running and port matches your instance
                
                var message = new HttpRequestMessage(HttpMethod.Get, $"{configStored_WeatherForecastUri}");
                
                //No AUTH assumed
                                
                var response = await _httpClient.SendAsync(message);
                var content = await response.Content.ReadAsStringAsync();

                if (content.Length == 0)
                {
                    //something is not right
                }

                if (response.StatusCode != HttpStatusCode.OK)
                {                    
                    throw new Exception("OK not received");
                }

                var weatherForecastVm = JsonConvert.DeserializeObject<WeatherForecastViewModel>(content);

                return weatherForecastVm;

            }
            catch (Exception ex)
            {
                //manage this
            }

            return null;
        }
    }
}
